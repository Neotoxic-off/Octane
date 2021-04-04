using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

using SETTINGS;

namespace Ara_Ara
{
    public partial class Octane : Form
    {
        Settings.Rootobject settings = null;
        ImageList icons = null;

        public Octane()
        {
            InitializeComponent();
        }

        private int count_char(string str, char c)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    total++;
            }
            return (total);
        }
        private Task load_settings()
        {
            settings = new Settings.Rootobject();
            settings = JsonConvert.DeserializeObject<Settings.Rootobject>(File.ReadAllText("Settings\\Settings.json"));
            Array.Sort(settings.Applications);

            return (Task.CompletedTask);
        }

        private int get_index(string[] data, string value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].ToLower().Contains(value.ToLower()))
                    return (i);
            }
            return (-1);
        }

        private Task load_applications()
        {
            string name = null;
            string[] images = Directory.GetFiles("Ressources", "*.png");

            icons = new ImageList();
            icons.ImageSize = new Size(25, 25);

            for (int i = 0; i < images.Length; i++)
            {
                icons.Images.Add(Image.FromFile(images[i]));
            }

            for (int i = 0; i < settings.Applications.Length; i++)
            {
                name = settings.Applications[i].Split('|')[0];
                if (get_index(images, name) > -1)
                    Applications.Items.Add(name, get_index(images, name));
                else
                    Applications.Items.Add(name, get_index(images, "default"));
            }

            Applications.SmallImageList = icons;

            return (Task.CompletedTask);
        }

        private bool check_all()
        {
            if (Directory.Exists("Settings") == false)
            {
                MessageBox.Show("Error 'Settings' folder missing", "Error fail to load");
                return (false);
            }
            else
            {
                if (File.Exists("Settings\\Settings.json") == false)
                {
                    MessageBox.Show("Error 'Settings\\Settings.json' file configuration missing", "Error fail to load");
                    return (false);
                }
            }
            if (Directory.Exists("Ressources") == false)
            {
                MessageBox.Show("Error 'Ressources' folder missing", "Error fail to load");
                return (false);
            }
            if (Directory.Exists("Setup") == false)
                Directory.CreateDirectory("Setup");
            return (true);
        }

        private Task load()
        {
            if (check_all() == true)
            {
                load_settings().Wait();
                load_applications().Wait();
                return (Task.CompletedTask);
            }

            Application.Exit();
            return (Task.CompletedTask);
        }

        private void AraAra_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            load().Wait();
            Cursor = Cursors.Default;
        }

        private async Task<Task> download(string folder, string url)
        {
            string extension = null;
            string name = url.Split('/')[count_char(url, '/')];
            int extension_check = count_char(name, '.');

            Console.WriteLine(name);
            if (extension_check > 0)
            {
                extension = name.Split('.')[extension_check];
                name = $"Setup\\{folder}.{extension}";
            } else
            {
                name = $"Setup\\{folder}.exe";
            }

            using (var client = new WebClient())
            {
                client.DownloadFile(url, name);
            }

            return (Task.CompletedTask);
        }

        private int get_items()
        {
            return (Applications.CheckedItems.Count);
        }

        private async Task<Task> download_task(int i)
        {
            Task task;

            if (Applications.Items[i].Checked == true)
            {
                if (Applications.Items[i].Text == settings.Applications[i].Split('|')[0])
                {
                    task = await Task.Run(() => download(settings.Applications[i].Split('|')[0], settings.Applications[i].Split('|')[1]));
                }
            }

            return (Task.CompletedTask);
        }

        private async void Install_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DialogResult choice;

            if (get_items() > 0)
            {
                choice = MessageBox.Show($"{get_items()} package(s) will be downloaded\nDo you want to continue ?", "Verification", MessageBoxButtons.YesNo);
                if (choice == DialogResult.Yes)
                {
                    for (int i = 0; i < settings.Applications.Length; i++)
                    {
                        download_task(i);
                    }
                }
            }

            Cursor = Cursors.Default;
        }

        private void darktheme_CheckedChanged(object sender, EventArgs e)
        {
            if (darktheme.Checked == true)
            {
                BackColor = Color.FromArgb(44, 47, 51);
                groupBox1.BackColor = Color.FromArgb(44, 47, 51);
                groupBox1.ForeColor = Color.White;
                Applications.BackColor = Color.FromArgb(44, 47, 51);
                Applications.ForeColor = Color.White;
            } else
            {
                BackColor = Color.White;
                groupBox1.BackColor = Color.White;
                groupBox1.ForeColor = Color.Black;
                Applications.BackColor = Color.White;
                Applications.ForeColor = Color.Black;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version:\t{settings.Version}\nAuthor:\tNeo");
        }
    }
}

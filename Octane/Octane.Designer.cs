
namespace Ara_Ara
{
    partial class Octane
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Octane));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Applications = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Install = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.about = new System.Windows.Forms.Button();
            this.darktheme = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Applications);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 363);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Applications ";
            // 
            // Applications
            // 
            this.Applications.BackColor = System.Drawing.Color.White;
            this.Applications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Applications.CheckBoxes = true;
            this.Applications.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Applications.HideSelection = false;
            this.Applications.Location = new System.Drawing.Point(13, 26);
            this.Applications.Margin = new System.Windows.Forms.Padding(10);
            this.Applications.MultiSelect = false;
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(564, 315);
            this.Applications.TabIndex = 10;
            this.Applications.UseCompatibleStateImageBehavior = false;
            this.Applications.View = System.Windows.Forms.View.SmallIcon;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 363);
            this.panel2.TabIndex = 8;
            // 
            // Install
            // 
            this.Install.ForeColor = System.Drawing.Color.Black;
            this.Install.Location = new System.Drawing.Point(516, 14);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(85, 23);
            this.Install.TabIndex = 8;
            this.Install.Text = "Install";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.about);
            this.panel1.Controls.Add(this.darktheme);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Install);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 50);
            this.panel1.TabIndex = 9;
            // 
            // about
            // 
            this.about.ForeColor = System.Drawing.Color.Black;
            this.about.Location = new System.Drawing.Point(425, 14);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(85, 23);
            this.about.TabIndex = 11;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // darktheme
            // 
            this.darktheme.AutoSize = true;
            this.darktheme.Location = new System.Drawing.Point(12, 18);
            this.darktheme.Name = "darktheme";
            this.darktheme.Size = new System.Drawing.Size(85, 17);
            this.darktheme.TabIndex = 10;
            this.darktheme.Text = "Dark Theme";
            this.darktheme.UseVisualStyleBackColor = true;
            this.darktheme.CheckedChanged += new System.EventHandler(this.darktheme_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 1);
            this.panel3.TabIndex = 9;
            // 
            // Octane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Octane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Octane";
            this.Load += new System.EventHandler(this.AraAra_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView Applications;
        private System.Windows.Forms.CheckBox darktheme;
        private System.Windows.Forms.Button about;
    }
}


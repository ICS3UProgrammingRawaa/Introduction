namespace PhotographyAppRawaa
{
    partial class frmPhotographyApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPhotography = new System.Windows.Forms.Label();
            this.lblBlackAndWhite = new System.Windows.Forms.Label();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhotography
            // 
            this.lblPhotography.AutoSize = true;
            this.lblPhotography.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhotography.Font = new System.Drawing.Font("Sylfaen", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotography.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPhotography.Location = new System.Drawing.Point(72, 40);
            this.lblPhotography.Name = "lblPhotography";
            this.lblPhotography.Size = new System.Drawing.Size(297, 62);
            this.lblPhotography.TabIndex = 0;
            this.lblPhotography.Text = "Photography ";
            // 
            // lblBlackAndWhite
            // 
            this.lblBlackAndWhite.AutoSize = true;
            this.lblBlackAndWhite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBlackAndWhite.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackAndWhite.ForeColor = System.Drawing.Color.Silver;
            this.lblBlackAndWhite.Location = new System.Drawing.Point(200, 102);
            this.lblBlackAndWhite.Name = "lblBlackAndWhite";
            this.lblBlackAndWhite.Size = new System.Drawing.Size(268, 51);
            this.lblBlackAndWhite.TabIndex = 1;
            this.lblBlackAndWhite.Text = "Black and White";
            this.lblBlackAndWhite.Click += new System.EventHandler(this.LblArchitecture_Click);
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 2;
            this.mnuProgram.Text = "menuStrip1";
            // 
            // mniProgram
            // 
            this.mniProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniProgram.Name = "mniProgram";
            this.mniProgram.Size = new System.Drawing.Size(65, 20);
            this.mniProgram.Text = "Program";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // frmPhotographyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PhotographyAppRawaa.Properties.Resources.pexels_photo_57905;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBlackAndWhite);
            this.Controls.Add(this.lblPhotography);
            this.Controls.Add(this.mnuProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmPhotographyApp";
            this.Text = "Photography App By Rawaa";
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhotography;
        private System.Windows.Forms.Label lblBlackAndWhite;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}


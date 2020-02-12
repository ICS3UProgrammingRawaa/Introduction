namespace PerAreaVolRawaa
{
    partial class frmPerAreaVol
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
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.mniProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(511, 84);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(25, 13);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "???";
            this.lblPerimeter.Click += new System.EventHandler(this.LblPerimeter_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(511, 220);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "???";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(511, 366);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(25, 13);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "???";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPerimeter.Location = new System.Drawing.Point(170, 28);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(208, 124);
            this.btnPerimeter.TabIndex = 3;
            this.btnPerimeter.Text = "Calculate the Perimeter of a rectangle with length 7cm and width 5cm";
            this.btnPerimeter.UseVisualStyleBackColor = false;
            this.btnPerimeter.Click += new System.EventHandler(this.BtnPerimeter_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(170, 167);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(208, 119);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calculate the Area of circle with a radius of 4cm";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.BtnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(170, 306);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(208, 132);
            this.btnVolume.TabIndex = 5;
            this.btnVolume.Text = "Calculate the Volume of a sphere with a radius of 12cm";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniProgram});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 6;
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
            // frmPerAreaVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmPerAreaVol";
            this.Text = "Perimeter, Area, Volume By Rawaa";
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.ToolStripMenuItem mniProgram;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}


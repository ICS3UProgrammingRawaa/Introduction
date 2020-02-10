namespace HelloWorldRawaa
{
    partial class frmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.lblSignature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.Black;
            this.lblHelloWorld.Location = new System.Drawing.Point(23, 24);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(264, 58);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello,World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.LblHelloWorld_Click);
            // 
            // picCamera
            // 
            this.picCamera.Image = global::HelloWorldRawaa.Properties.Resources.camera;
            this.picCamera.Location = new System.Drawing.Point(193, 85);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(381, 309);
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamera.TabIndex = 1;
            this.picCamera.TabStop = false;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("ScriptC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(599, 369);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(189, 52);
            this.lblSignature.TabIndex = 2;
            this.lblSignature.Text = "By Rawaa";
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World! By Rawaa";
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Label lblSignature;
    }
}


namespace HelloIntRawaa
{
    partial class frmHelloInt
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.radArabic = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.radFrançais = new System.Windows.Forms.RadioButton();
            this.radSpanish = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Stylus BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Red;
            this.lblGreeting.Location = new System.Drawing.Point(245, 117);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(296, 58);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.radSpanish);
            this.grbRadioButtons.Controls.Add(this.radFrançais);
            this.grbRadioButtons.Controls.Add(this.radArabic);
            this.grbRadioButtons.Controls.Add(this.radEnglish);
            this.grbRadioButtons.Location = new System.Drawing.Point(62, 271);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(699, 155);
            this.grbRadioButtons.TabIndex = 1;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Text = "Language";
            // 
            // radArabic
            // 
            this.radArabic.AutoSize = true;
            this.radArabic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArabic.Location = new System.Drawing.Point(221, 74);
            this.radArabic.Name = "radArabic";
            this.radArabic.Size = new System.Drawing.Size(68, 29);
            this.radArabic.TabIndex = 1;
            this.radArabic.TabStop = true;
            this.radArabic.Text = "عربى";
            this.radArabic.UseVisualStyleBackColor = true;
            this.radArabic.CheckedChanged += new System.EventHandler(this.RadArabic_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEnglish.Location = new System.Drawing.Point(36, 74);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(101, 29);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // radFrançais
            // 
            this.radFrançais.AutoSize = true;
            this.radFrançais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFrançais.Location = new System.Drawing.Point(357, 74);
            this.radFrançais.Name = "radFrançais";
            this.radFrançais.Size = new System.Drawing.Size(113, 29);
            this.radFrançais.TabIndex = 2;
            this.radFrançais.TabStop = true;
            this.radFrançais.Text = "Français";
            this.radFrançais.UseVisualStyleBackColor = true;
            this.radFrançais.CheckedChanged += new System.EventHandler(this.RadFrançais_CheckedChanged);
            // 
            // radSpanish
            // 
            this.radSpanish.AutoSize = true;
            this.radSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSpanish.Location = new System.Drawing.Point(524, 74);
            this.radSpanish.Name = "radSpanish";
            this.radSpanish.Size = new System.Drawing.Size(108, 29);
            this.radSpanish.TabIndex = 3;
            this.radSpanish.TabStop = true;
            this.radSpanish.Text = "Español";
            this.radSpanish.UseVisualStyleBackColor = true;
            this.radSpanish.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // frmHelloInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloInt";
            this.Text = "Hello, World! International By Rawaa";
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton radEnglish;
        private System.Windows.Forms.RadioButton radArabic;
        private System.Windows.Forms.RadioButton radSpanish;
        private System.Windows.Forms.RadioButton radFrançais;
    }
}


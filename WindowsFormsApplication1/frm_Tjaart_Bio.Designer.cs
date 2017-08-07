namespace WindowsFormsApplication1
{
    partial class frm_Tjaart_Bio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbtn_Calculate_Min = new MetroFramework.Controls.MetroButton();
            this.mtxbEnter_Number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Tjaart;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mbtn_Calculate_Min
            // 
            this.mbtn_Calculate_Min.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtn_Calculate_Min.Highlight = true;
            this.mbtn_Calculate_Min.Location = new System.Drawing.Point(416, 422);
            this.mbtn_Calculate_Min.Name = "mbtn_Calculate_Min";
            this.mbtn_Calculate_Min.Size = new System.Drawing.Size(75, 23);
            this.mbtn_Calculate_Min.Style = MetroFramework.MetroColorStyle.Red;
            this.mbtn_Calculate_Min.TabIndex = 1;
            this.mbtn_Calculate_Min.Text = "Calculate";
            this.mbtn_Calculate_Min.UseCustomBackColor = true;
            this.mbtn_Calculate_Min.UseSelectable = true;
            this.mbtn_Calculate_Min.UseStyleColors = true;
            this.mbtn_Calculate_Min.Click += new System.EventHandler(this.mbtn_Calculate_Min_Click);
            // 
            // mtxbEnter_Number
            // 
            // 
            // 
            // 
            this.mtxbEnter_Number.CustomButton.Image = null;
            this.mtxbEnter_Number.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.mtxbEnter_Number.CustomButton.Name = "";
            this.mtxbEnter_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxbEnter_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxbEnter_Number.CustomButton.TabIndex = 1;
            this.mtxbEnter_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxbEnter_Number.CustomButton.UseSelectable = true;
            this.mtxbEnter_Number.CustomButton.Visible = false;
            this.mtxbEnter_Number.Lines = new string[0];
            this.mtxbEnter_Number.Location = new System.Drawing.Point(300, 422);
            this.mtxbEnter_Number.MaxLength = 32767;
            this.mtxbEnter_Number.Name = "mtxbEnter_Number";
            this.mtxbEnter_Number.PasswordChar = '\0';
            this.mtxbEnter_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxbEnter_Number.SelectedText = "";
            this.mtxbEnter_Number.SelectionLength = 0;
            this.mtxbEnter_Number.SelectionStart = 0;
            this.mtxbEnter_Number.Size = new System.Drawing.Size(98, 23);
            this.mtxbEnter_Number.Style = MetroFramework.MetroColorStyle.Red;
            this.mtxbEnter_Number.TabIndex = 2;
            this.mtxbEnter_Number.UseCustomBackColor = true;
            this.mtxbEnter_Number.UseSelectable = true;
            this.mtxbEnter_Number.UseStyleColors = true;
            this.mtxbEnter_Number.WaterMark = "Enter a number";
            this.mtxbEnter_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxbEnter_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(149, 422);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Please enter a number:";
            // 
            // frm_Tjaart_Bio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 468);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtxbEnter_Number);
            this.Controls.Add(this.mbtn_Calculate_Min);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Tjaart_Bio";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_Tjaart_Bio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton mbtn_Calculate_Min;
        private MetroFramework.Controls.MetroTextBox mtxbEnter_Number;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
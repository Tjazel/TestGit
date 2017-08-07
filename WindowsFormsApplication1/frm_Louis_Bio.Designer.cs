namespace WindowsFormsApplication1
{
    partial class frm_Louis_Bio
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
            this.louisLabel = new MetroFramework.Controls.MetroLabel();
            this.tbxEnterNum = new MetroFramework.Controls.MetroTextBox();
            this.mbtn_Calculate_Min = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Louis;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // louisLabel
            // 
            this.louisLabel.AutoSize = true;
            this.louisLabel.Location = new System.Drawing.Point(110, 409);
            this.louisLabel.Name = "louisLabel";
            this.louisLabel.Size = new System.Drawing.Size(144, 19);
            this.louisLabel.TabIndex = 6;
            this.louisLabel.Text = "Please enter a number:";
            this.louisLabel.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // tbxEnterNum
            // 
            // 
            // 
            // 
            this.tbxEnterNum.CustomButton.Image = null;
            this.tbxEnterNum.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tbxEnterNum.CustomButton.Name = "";
            this.tbxEnterNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxEnterNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxEnterNum.CustomButton.TabIndex = 1;
            this.tbxEnterNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxEnterNum.CustomButton.UseSelectable = true;
            this.tbxEnterNum.CustomButton.Visible = false;
            this.tbxEnterNum.Lines = new string[0];
            this.tbxEnterNum.Location = new System.Drawing.Point(261, 409);
            this.tbxEnterNum.MaxLength = 32767;
            this.tbxEnterNum.Name = "tbxEnterNum";
            this.tbxEnterNum.PasswordChar = '\0';
            this.tbxEnterNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEnterNum.SelectedText = "";
            this.tbxEnterNum.SelectionLength = 0;
            this.tbxEnterNum.SelectionStart = 0;
            this.tbxEnterNum.Size = new System.Drawing.Size(98, 23);
            this.tbxEnterNum.Style = MetroFramework.MetroColorStyle.Red;
            this.tbxEnterNum.TabIndex = 5;
            this.tbxEnterNum.UseCustomBackColor = true;
            this.tbxEnterNum.UseSelectable = true;
            this.tbxEnterNum.UseStyleColors = true;
            this.tbxEnterNum.WaterMark = "Enter a number";
            this.tbxEnterNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxEnterNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbxEnterNum.Click += new System.EventHandler(this.mtxbEnter_Number_Click);
            // 
            // mbtn_Calculate_Min
            // 
            this.mbtn_Calculate_Min.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtn_Calculate_Min.Highlight = true;
            this.mbtn_Calculate_Min.Location = new System.Drawing.Point(377, 409);
            this.mbtn_Calculate_Min.Name = "mbtn_Calculate_Min";
            this.mbtn_Calculate_Min.Size = new System.Drawing.Size(75, 23);
            this.mbtn_Calculate_Min.Style = MetroFramework.MetroColorStyle.Red;
            this.mbtn_Calculate_Min.TabIndex = 4;
            this.mbtn_Calculate_Min.Text = "Calculate";
            this.mbtn_Calculate_Min.UseCustomBackColor = true;
            this.mbtn_Calculate_Min.UseSelectable = true;
            this.mbtn_Calculate_Min.UseStyleColors = true;
            this.mbtn_Calculate_Min.Click += new System.EventHandler(this.mbtn_Calculate_Min_Click);
            // 
            // frm_Louis_Bio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 436);
            this.Controls.Add(this.louisLabel);
            this.Controls.Add(this.tbxEnterNum);
            this.Controls.Add(this.mbtn_Calculate_Min);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Louis_Bio";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frm_Louis_Bio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel louisLabel;
        private MetroFramework.Controls.MetroTextBox tbxEnterNum;
        private MetroFramework.Controls.MetroButton mbtn_Calculate_Min;
    }
}
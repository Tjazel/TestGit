namespace WindowsFormsApplication1
{
    partial class frm_Denieke_Bio
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
            this.pnlBio = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCalculate = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxbEnter_Number = new MetroFramework.Controls.MetroTextBox();
            this.mbtn_Calculate_Max = new MetroFramework.Controls.MetroButton();
            this.pnlBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCalculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBio
            // 
            this.pnlBio.Controls.Add(this.pictureBox1);
            this.pnlBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBio.Location = new System.Drawing.Point(20, 60);
            this.pnlBio.Name = "pnlBio";
            this.pnlBio.Size = new System.Drawing.Size(652, 397);
            this.pnlBio.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Denieke;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCalculate
            // 
            this.pnlCalculate.Controls.Add(this.metroLabel1);
            this.pnlCalculate.Controls.Add(this.mtxbEnter_Number);
            this.pnlCalculate.Controls.Add(this.mbtn_Calculate_Max);
            this.pnlCalculate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCalculate.Location = new System.Drawing.Point(20, 357);
            this.pnlCalculate.Name = "pnlCalculate";
            this.pnlCalculate.Size = new System.Drawing.Size(652, 100);
            this.pnlCalculate.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(145, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Please enter a number:";
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
            this.mtxbEnter_Number.Location = new System.Drawing.Point(296, 18);
            this.mtxbEnter_Number.MaxLength = 32767;
            this.mtxbEnter_Number.Name = "mtxbEnter_Number";
            this.mtxbEnter_Number.PasswordChar = '\0';
            this.mtxbEnter_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxbEnter_Number.SelectedText = "";
            this.mtxbEnter_Number.SelectionLength = 0;
            this.mtxbEnter_Number.SelectionStart = 0;
            this.mtxbEnter_Number.Size = new System.Drawing.Size(98, 23);
            this.mtxbEnter_Number.Style = MetroFramework.MetroColorStyle.Red;
            this.mtxbEnter_Number.TabIndex = 7;
            this.mtxbEnter_Number.UseCustomBackColor = true;
            this.mtxbEnter_Number.UseSelectable = true;
            this.mtxbEnter_Number.UseStyleColors = true;
            this.mtxbEnter_Number.WaterMark = "Enter a number";
            this.mtxbEnter_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxbEnter_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtn_Calculate_Max
            // 
            this.mbtn_Calculate_Max.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtn_Calculate_Max.Highlight = true;
            this.mbtn_Calculate_Max.Location = new System.Drawing.Point(412, 18);
            this.mbtn_Calculate_Max.Name = "mbtn_Calculate_Max";
            this.mbtn_Calculate_Max.Size = new System.Drawing.Size(75, 23);
            this.mbtn_Calculate_Max.Style = MetroFramework.MetroColorStyle.Red;
            this.mbtn_Calculate_Max.TabIndex = 6;
            this.mbtn_Calculate_Max.Text = "Calculate";
            this.mbtn_Calculate_Max.UseCustomBackColor = true;
            this.mbtn_Calculate_Max.UseSelectable = true;
            this.mbtn_Calculate_Max.UseStyleColors = true;
            this.mbtn_Calculate_Max.Click += new System.EventHandler(this.mbtn_Calculate_Max_Click);
            // 
            // frm_Denieke_Bio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 477);
            this.Controls.Add(this.pnlCalculate);
            this.Controls.Add(this.pnlBio);
            this.Name = "frm_Denieke_Bio";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.pnlBio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCalculate.ResumeLayout(false);
            this.pnlCalculate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCalculate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtxbEnter_Number;
        private MetroFramework.Controls.MetroButton mbtn_Calculate_Max;
    }
}
namespace ListboxUpAndDown
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.UpPictureBox = new System.Windows.Forms.PictureBox();
            this.DownPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CityListBox
            // 
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.Items.AddRange(new object[] {
            "Dhaka",
            "London",
            "Paris",
            "Melborn"});
            this.CityListBox.Location = new System.Drawing.Point(12, 12);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(145, 225);
            this.CityListBox.TabIndex = 0;
            // 
            // UpPictureBox
            // 
            this.UpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UpPictureBox.Image")));
            this.UpPictureBox.Location = new System.Drawing.Point(183, 12);
            this.UpPictureBox.Name = "UpPictureBox";
            this.UpPictureBox.Size = new System.Drawing.Size(21, 27);
            this.UpPictureBox.TabIndex = 1;
            this.UpPictureBox.TabStop = false;
            this.UpPictureBox.Click += new System.EventHandler(this.UpPictureBox_Click);
            // 
            // DownPictureBox
            // 
            this.DownPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DownPictureBox.Image")));
            this.DownPictureBox.Location = new System.Drawing.Point(183, 60);
            this.DownPictureBox.Name = "DownPictureBox";
            this.DownPictureBox.Size = new System.Drawing.Size(21, 27);
            this.DownPictureBox.TabIndex = 2;
            this.DownPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 320);
            this.Controls.Add(this.DownPictureBox);
            this.Controls.Add(this.UpPictureBox);
            this.Controls.Add(this.CityListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List Box";
            ((System.ComponentModel.ISupportInitialize)(this.UpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CityListBox;
        private System.Windows.Forms.PictureBox UpPictureBox;
        private System.Windows.Forms.PictureBox DownPictureBox;
    }
}


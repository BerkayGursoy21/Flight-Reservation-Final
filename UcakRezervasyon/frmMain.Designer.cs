namespace UcakRezervasyon
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUcak = new Button();
            btnLokasyon = new Button();
            btnRezervasyon = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnUcak
            // 
            btnUcak.Location = new Point(88, 234);
            btnUcak.Name = "btnUcak";
            btnUcak.Size = new Size(208, 40);
            btnUcak.TabIndex = 0;
            btnUcak.Text = "Uçak Formu";
            btnUcak.UseVisualStyleBackColor = true;
            btnUcak.Click += btnUcak_Click;
            // 
            // btnLokasyon
            // 
            btnLokasyon.Location = new Point(88, 178);
            btnLokasyon.Name = "btnLokasyon";
            btnLokasyon.Size = new Size(208, 40);
            btnLokasyon.TabIndex = 1;
            btnLokasyon.Text = "Lokasyon Formu";
            btnLokasyon.UseVisualStyleBackColor = true;
            btnLokasyon.Click += btnLokasyon_Click;
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.Location = new Point(88, 122);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(208, 40);
            btnRezervasyon.TabIndex = 2;
            btnRezervasyon.Text = "Rezervasyon Formu";
            btnRezervasyon.UseVisualStyleBackColor = true;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(118, 30);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 3;
            label1.Text = "Uçak Rezervasyon Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Flight_Reservation.Properties.Resources.airplane1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(394, 317);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnRezervasyon);
            Controls.Add(btnLokasyon);
            Controls.Add(btnUcak);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uçak Rezervasyon Sistemi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUcak;
        private Button btnLokasyon;
        private Button btnRezervasyon;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

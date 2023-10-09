namespace _06._10._2023_uygulama3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAdsoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnKaydet = new Button();
            btnListeyeDon = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 112);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "Yaş";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 79);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 146);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 1;
            label4.Text = "Adres";
            // 
            // txtAdsoyad
            // 
            txtAdsoyad.Location = new Point(109, 43);
            txtAdsoyad.Name = "txtAdsoyad";
            txtAdsoyad.Size = new Size(148, 23);
            txtAdsoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(109, 76);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(148, 23);
            txtTelefon.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(109, 155);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(148, 119);
            txtAdres.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(111, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(109, 291);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(148, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListeyeDon
            // 
            btnListeyeDon.Location = new Point(111, 320);
            btnListeyeDon.Name = "btnListeyeDon";
            btnListeyeDon.Size = new Size(146, 23);
            btnListeyeDon.TabIndex = 7;
            btnListeyeDon.Text = "Listeye Dön";
            btnListeyeDon.UseVisualStyleBackColor = true;
            btnListeyeDon.Click += btnListeyeDon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 376);
            Controls.Add(btnListeyeDon);
            Controls.Add(btnKaydet);
            Controls.Add(numericUpDown1);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdsoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdsoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private NumericUpDown numericUpDown1;
        private Button btnKaydet;
        private Button btnListeyeDon;
    }
}
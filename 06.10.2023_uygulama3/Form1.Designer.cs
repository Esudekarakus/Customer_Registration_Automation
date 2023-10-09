namespace _06._10._2023_uygulama3
{
    partial class Form1
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
            lstMusteriler = new ListBox();
            btnMusteriEkle = new Button();
            SuspendLayout();
            // 
            // lstMusteriler
            // 
            lstMusteriler.FormattingEnabled = true;
            lstMusteriler.ItemHeight = 15;
            lstMusteriler.Location = new Point(30, 26);
            lstMusteriler.Name = "lstMusteriler";
            lstMusteriler.Size = new Size(216, 154);
            lstMusteriler.TabIndex = 0;
            lstMusteriler.SelectedIndexChanged += lstMusteriler_SelectedIndexChanged;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(31, 208);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(216, 30);
            btnMusteriEkle.TabIndex = 1;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 292);
            Controls.Add(btnMusteriEkle);
            Controls.Add(lstMusteriler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMusteriler;
        private Button btnMusteriEkle;
    }
}
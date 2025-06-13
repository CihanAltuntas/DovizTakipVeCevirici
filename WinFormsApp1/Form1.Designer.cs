namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LiraMetin = new TextBox();
            DolarMetin = new TextBox();
            EuroMetin = new TextBox();
            PoundMetin = new TextBox();
            YenMetin = new TextBox();
            Doviz = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            Cevir = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir__1_;
            pictureBox1.Location = new Point(16, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.indir__2_;
            pictureBox2.Location = new Point(13, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.indir__3_;
            pictureBox3.Location = new Point(16, 243);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.indir__4_;
            pictureBox4.Location = new Point(16, 344);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.indir__5_;
            pictureBox5.Location = new Point(16, 446);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Türk Lirası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 138);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 6;
            label2.Text = "Amerikan Doları";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 243);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Avrupa Eurosu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 344);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 8;
            label4.Text = "İngiliz Poundu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 446);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Japon Yeni";
            label5.Click += label5_Click;
            // 
            // LiraMetin
            // 
            LiraMetin.Location = new Point(96, 62);
            LiraMetin.Name = "LiraMetin";
            LiraMetin.Size = new Size(125, 27);
            LiraMetin.TabIndex = 10;
            // 
            // DolarMetin
            // 
            DolarMetin.Location = new Point(95, 169);
            DolarMetin.Name = "DolarMetin";
            DolarMetin.Size = new Size(125, 27);
            DolarMetin.TabIndex = 11;
            DolarMetin.TextChanged += textBox2_TextChanged;
            // 
            // EuroMetin
            // 
            EuroMetin.Location = new Point(96, 278);
            EuroMetin.Name = "EuroMetin";
            EuroMetin.Size = new Size(125, 27);
            EuroMetin.TabIndex = 12;
            // 
            // PoundMetin
            // 
            PoundMetin.Location = new Point(96, 379);
            PoundMetin.Name = "PoundMetin";
            PoundMetin.Size = new Size(125, 27);
            PoundMetin.TabIndex = 13;
            // 
            // YenMetin
            // 
            YenMetin.Location = new Point(96, 481);
            YenMetin.Name = "YenMetin";
            YenMetin.Size = new Size(125, 27);
            YenMetin.TabIndex = 14;
            // 
            // Doviz
            // 
            Doviz.Location = new Point(277, 18);
            Doviz.Name = "Doviz";
            Doviz.Size = new Size(94, 29);
            Doviz.TabIndex = 15;
            Doviz.Text = "Göster";
            Doviz.UseVisualStyleBackColor = true;
            Doviz.Click += Doviz_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Türk Lirası", "Amerikan Doları", "Avrupa Eurosu", "İngiliz Poundu", "Japon Yeni" });
            comboBox1.Location = new Point(75, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Türk Lirası", "Amerikan Doları", "Avrupa Eurosu", "İngiliz Poundu", "Japon Yeni" });
            comboBox2.Location = new Point(362, 50);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 17;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 97);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(388, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 19;
            // 
            // Cevir
            // 
            Cevir.Location = new Point(248, 49);
            Cevir.Name = "Cevir";
            Cevir.Size = new Size(94, 29);
            Cevir.TabIndex = 20;
            Cevir.Text = "Çevir";
            Cevir.UseVisualStyleBackColor = true;
            Cevir.Click += Cevir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Doviz);
            groupBox1.Controls.Add(YenMetin);
            groupBox1.Controls.Add(PoundMetin);
            groupBox1.Controls.Add(EuroMetin);
            groupBox1.Controls.Add(DolarMetin);
            groupBox1.Controls.Add(LiraMetin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(15, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 547);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Döviz Giriş Modül";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Cevir);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(463, 55);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(576, 188);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Döviz Çeviri Modül";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 586);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox LiraMetin;
        private TextBox DolarMetin;
        private TextBox EuroMetin;
        private TextBox PoundMetin;
        private TextBox YenMetin;
        private Button Doviz;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Button Cevir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}

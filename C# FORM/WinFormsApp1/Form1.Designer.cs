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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.j = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtevtelefonu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtceptelefonu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkayittarihi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.j.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 625);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 564);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÜŞTERİ LİSTESİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Müşteri Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Müşteri Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(576, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Müşteri Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // j
            // 
            this.j.Controls.Add(this.tabPage1);
            this.j.Controls.Add(this.tabPage2);
            this.j.Location = new System.Drawing.Point(339, 57);
            this.j.Name = "j";
            this.j.SelectedIndex = 0;
            this.j.Size = new System.Drawing.Size(499, 564);
            this.j.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtevtelefonu);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtceptelefonu);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtsoyadi);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtadi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtkayittarihi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Bilgisi";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtevtelefonu
            // 
            this.txtevtelefonu.Location = new System.Drawing.Point(119, 153);
            this.txtevtelefonu.Name = "txtevtelefonu";
            this.txtevtelefonu.Size = new System.Drawing.Size(352, 27);
            this.txtevtelefonu.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ev Telefonu :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtceptelefonu
            // 
            this.txtceptelefonu.Location = new System.Drawing.Point(119, 126);
            this.txtceptelefonu.Name = "txtceptelefonu";
            this.txtceptelefonu.Size = new System.Drawing.Size(352, 27);
            this.txtceptelefonu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 27);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cep Telefonu :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Location = new System.Drawing.Point(119, 99);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(352, 27);
            this.txtsoyadi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Soyadı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(119, 72);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(352, 27);
            this.txtadi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtkayittarihi
            // 
            this.txtkayittarihi.Location = new System.Drawing.Point(119, 45);
            this.txtkayittarihi.Name = "txtkayittarihi";
            this.txtkayittarihi.ReadOnly = true;
            this.txtkayittarihi.Size = new System.Drawing.Size(352, 27);
            this.txtkayittarihi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kayıt Tarihi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 18);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(352, 27);
            this.txtid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fatura Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(119, 157);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(352, 88);
            this.textBox7.TabIndex = 25;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(6, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "Adres :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(119, 130);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(352, 27);
            this.textBox8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 27);
            this.label9.TabIndex = 22;
            this.label9.Text = "İlçe :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(119, 103);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(352, 27);
            this.textBox9.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "Şehir :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(119, 76);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(352, 27);
            this.textBox10.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(6, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 27);
            this.label11.TabIndex = 18;
            this.label11.Text = "Vergi No :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(119, 49);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(352, 27);
            this.textBox11.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 27);
            this.label12.TabIndex = 16;
            this.label12.Text = "Vergi Dairesi :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(119, 22);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(352, 27);
            this.textBox12.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 27);
            this.label13.TabIndex = 14;
            this.label13.Text = "Unvan :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(839, 626);
            this.Controls.Add(this.j);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Müşteri Takip Uygulaması";
            this.panel1.ResumeLayout(false);
            this.j.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabControl j;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtevtelefonu;
        private Label label6;
        private TextBox txtceptelefonu;
        private Label label7;
        private TextBox txtsoyadi;
        private Label label5;
        private TextBox txtadi;
        private Label label4;
        private TextBox txtkayittarihi;
        private Label label3;
        private TextBox txtid;
        private Label label2;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private Label label12;
        private TextBox textBox12;
        private Label label13;
    }
}
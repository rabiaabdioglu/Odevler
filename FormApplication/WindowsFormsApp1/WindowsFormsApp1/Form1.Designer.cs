namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.islem_tiklama);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 27);
            this.button5.TabIndex = 8;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(243, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.islem_tiklama);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(98, 165);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(43, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(24, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 27);
            this.button8.TabIndex = 5;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(43, 27);
            this.button9.TabIndex = 12;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(243, 209);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 27);
            this.button10.TabIndex = 11;
            this.button10.Text = "*";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.islem_tiklama);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(98, 209);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 27);
            this.button11.TabIndex = 10;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 209);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 27);
            this.button12.TabIndex = 9;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(171, 252);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(43, 27);
            this.button13.TabIndex = 16;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(243, 252);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(43, 27);
            this.button14.TabIndex = 15;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.islem_tiklama);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(98, 252);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(43, 27);
            this.button15.TabIndex = 14;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.rakam_tiklama);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(24, 252);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(43, 27);
            this.button16.TabIndex = 13;
            this.button16.Text = "C";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.c_tiklama);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(307, 122);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(64, 156);
            this.button17.TabIndex = 17;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "İŞLEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "İŞLEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Location = new System.Drawing.Point(103, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 300);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HESAP MAKİNESİ";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(46, 29);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(115, 38);
            this.button18.TabIndex = 21;
            this.button18.Text = "form2";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button18;
    }
}


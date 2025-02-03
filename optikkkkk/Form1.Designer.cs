namespace optikkkkk
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.textBoxHocaAdi = new System.Windows.Forms.TextBox();
            this.radioButtonVize = new System.Windows.Forms.RadioButton();
            this.radioButtonFinal = new System.Windows.Forms.RadioButton();
            this.radioButtonButunleme = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "ogrenci bilgisi seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "kontrol et";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "sıfırla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(260, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "sonucları kaydet";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxDersAdi
            // 
            this.textBoxDersAdi.Location = new System.Drawing.Point(15, 37);
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(239, 22);
            this.textBoxDersAdi.TabIndex = 9;
            // 
            // textBoxHocaAdi
            // 
            this.textBoxHocaAdi.Location = new System.Drawing.Point(15, 81);
            this.textBoxHocaAdi.Name = "textBoxHocaAdi";
            this.textBoxHocaAdi.Size = new System.Drawing.Size(239, 22);
            this.textBoxHocaAdi.TabIndex = 10;
            // 
            // radioButtonVize
            // 
            this.radioButtonVize.AutoSize = true;
            this.radioButtonVize.Location = new System.Drawing.Point(12, 121);
            this.radioButtonVize.Name = "radioButtonVize";
            this.radioButtonVize.Size = new System.Drawing.Size(52, 20);
            this.radioButtonVize.TabIndex = 11;
            this.radioButtonVize.TabStop = true;
            this.radioButtonVize.Text = "vize";
            this.radioButtonVize.UseVisualStyleBackColor = true;
            // 
            // radioButtonFinal
            // 
            this.radioButtonFinal.AutoSize = true;
            this.radioButtonFinal.Location = new System.Drawing.Point(12, 147);
            this.radioButtonFinal.Name = "radioButtonFinal";
            this.radioButtonFinal.Size = new System.Drawing.Size(52, 20);
            this.radioButtonFinal.TabIndex = 12;
            this.radioButtonFinal.TabStop = true;
            this.radioButtonFinal.Text = "final";
            this.radioButtonFinal.UseVisualStyleBackColor = true;
            // 
            // radioButtonButunleme
            // 
            this.radioButtonButunleme.AutoSize = true;
            this.radioButtonButunleme.Location = new System.Drawing.Point(12, 173);
            this.radioButtonButunleme.Name = "radioButtonButunleme";
            this.radioButtonButunleme.Size = new System.Drawing.Size(90, 20);
            this.radioButtonButunleme.TabIndex = 13;
            this.radioButtonButunleme.TabStop = true;
            this.radioButtonButunleme.Text = "bütünleme";
            this.radioButtonButunleme.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ders adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hoca adı:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Maroon;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(1139, -2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 36);
            this.button6.TabIndex = 17;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(298, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Grup sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Soru sayısı";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(601, 39);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(524, 22);
            this.textBoxA.TabIndex = 22;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(601, 79);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(524, 22);
            this.textBoxB.TabIndex = 23;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(601, 127);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(524, 22);
            this.textBoxC.TabIndex = 24;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(601, 175);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(524, 22);
            this.textBoxD.TabIndex = 25;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(598, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(53, 16);
            this.labelA.TabIndex = 26;
            this.labelA.Text = "A grubu";
            this.labelA.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(601, 65);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(53, 16);
            this.labelB.TabIndex = 27;
            this.labelB.Text = "B grubu";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(598, 108);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(53, 16);
            this.labelC.TabIndex = 28;
            this.labelC.Text = "C grubu";
            this.labelC.Click += new System.EventHandler(this.labelC_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(598, 156);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(54, 16);
            this.labelD.TabIndex = 29;
            this.labelD.Text = "D grubu";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(122, 121);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Eksınav 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 147);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Eksınav 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(122, 173);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 20);
            this.radioButton3.TabIndex = 32;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Quiz";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 434);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonButunleme);
            this.Controls.Add(this.radioButtonFinal);
            this.Controls.Add(this.radioButtonVize);
            this.Controls.Add(this.textBoxHocaAdi);
            this.Controls.Add(this.textBoxDersAdi);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "33";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.TextBox textBoxHocaAdi;
        private System.Windows.Forms.RadioButton radioButtonVize;
        private System.Windows.Forms.RadioButton radioButtonFinal;
        private System.Windows.Forms.RadioButton radioButtonButunleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}


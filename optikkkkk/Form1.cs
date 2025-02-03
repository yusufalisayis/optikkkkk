using System;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel; // ClosedXML kütüphanesini ekleyin

namespace optikkkkk
{
    public partial class Form1 : Form
    {
        string DosyaYolu1; // Doğru cevapların dosya yolu
        string DosyaYolu2; // Öğrenci cevaplarının dosya yolu

        public Form1()
        {
            InitializeComponent();
            DataGridViewAyarla(); // DataGridView ayarlarını yap
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArayuzuBaslat(); // Form yüklendiğinde arayüzü düzenle
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // comboBox1'i doldur
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");

            // comboBox2'yi doldur
            comboBox2.Items.Add("21");
            comboBox2.Items.Add("26");
            comboBox2.Items.Add("51");
            comboBox2.Items.Add("101");

        }

        private void ArayuzuBaslat()
        {
            label3.Visible = false;
            textBoxA.Visible = false;
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            textBoxD.Visible = false;
            labelA.Visible = false;
            labelB.Visible = false;
            labelC.Visible = false;
            labelD.Visible = false;
        }

        private void DataGridViewAyarla()
        {
            // DataGridView'e yeni sütunlar ekliyoruz
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Ders";
            dataGridView1.Columns[1].Name = "Hoca";
            dataGridView1.Columns[2].Name = "Sınav Türü";
            dataGridView1.Columns[3].Name = "Öğrenci No";
            dataGridView1.Columns[4].Name = "Doğru";
            dataGridView1.Columns[5].Name = "Yanlış";
            dataGridView1.Columns[6].Name = "Boş";
            dataGridView1.Columns[7].Name = "Grup";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void CevapAnahtariYukle(string dosyaYolu)
        {
            try
            {
              
                string cevapAnahtari = File.ReadAllText(dosyaYolu).Trim(); // Dosyayı oku
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cevap anahtarı yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Filter = "Metin Dosyası (*.txt)|*.txt"
            };

            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu2 = file.FileName;
                label3.Visible = true;
                label3.Text = file.SafeFileName;
                button2.Visible = false;
            }
        }
        // Aynı veri kontrolü yapan metot
        private bool KayitVarMi(string ders, string hoca, string sinavTuru, string ogrenciNo)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Yeni eklenmemiş satırları kontrol et

                // Satırlardaki verileri kontrol et
                if (row.Cells[0].Value?.ToString() == ders &&
                    row.Cells[1].Value?.ToString() == hoca &&
                    row.Cells[2].Value?.ToString() == sinavTuru &&
                    row.Cells[3].Value?.ToString() == ogrenciNo)
                {
                    return true; // Aynı kayıt bulundu
                }
            }
            return false; // Aynı kayıt bulunmadı
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen öğeye göre TextBox'ları göster
            textBoxA.Visible = false; 
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            textBoxD.Visible = false;
            labelA.Visible = false;
            labelB.Visible = false;
            labelC.Visible = false;
            labelD.Visible = false;


            switch (comboBox1.SelectedItem.ToString())
            {
                case "1":
                    labelA.Visible=true;
                    textBoxA.Visible=true;
                    break;
                case "2":
                    labelA.Visible = true;
                    textBoxA.Visible = true;
                    textBoxB.Visible = true;
                    labelB.Visible=true;
                    break;
                case "3":
                    labelA.Visible = true;
                    textBoxA.Visible = true;
                    textBoxB.Visible = true;
                    labelB.Visible = true;
                    labelC.Visible=true;
                    textBoxC.Visible=true;
                    break;
                case "4":
                    labelA.Visible = true;
                    textBoxA.Visible = true;
                    textBoxB.Visible = true;
                    labelB.Visible = true;
                    labelC.Visible = true;
                    textBoxC.Visible = true;
                    labelD.Visible=true;
                    textBoxD.Visible=true;
                    break;
                default:
                    textBoxA.Visible = false; 
                    textBoxB.Visible = false;
                    textBoxC.Visible = false;
                    textBoxD.Visible = false;
                    labelA.Visible = false;
                    labelB.Visible = false;
                    labelC.Visible = false;
                    labelD.Visible = false;
                    break;
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string dersAdi = textBoxDersAdi.Text;
                string hocaAdi = textBoxHocaAdi.Text;
                string sinavTuru = GetSelectedSinavTuru();

                if (string.IsNullOrWhiteSpace(dersAdi) || string.IsNullOrWhiteSpace(hocaAdi))
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dogruCevaplar = GetCorrectAnswers();
                if (dogruCevaplar == null) return;

                string[] ogrenciSatirlari = File.ReadAllLines(DosyaYolu2);

                foreach (string satir in ogrenciSatirlari)
                {
                    if (string.IsNullOrWhiteSpace(satir)) continue;

                    string ogrenciNo = satir.Substring(0, 9);
                    string ogrenciCevaplar = satir.Substring(9).Trim();

                    if (ogrenciCevaplar.Length != dogruCevaplar.Length)
                    {
                        MessageBox.Show($"Öğrenci {ogrenciNo} için cevap uzunluğu hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (KayitVarMi(dersAdi, hocaAdi, sinavTuru, ogrenciNo))
                    {
                        MessageBox.Show($"Öğrenci {ogrenciNo} için aynı kayıt zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    int dogru = 0, yanlis = 0, bos = 0;

                    for (int i = 0; i < dogruCevaplar.Length; i++)
                    {
                        char dogruCevap = dogruCevaplar[i];
                        char ogrenciCevap = ogrenciCevaplar[i];

                        if (ogrenciCevap == '-')
                        {

                            bos++;
                        }
                        else if (ogrenciCevap == dogruCevap)
                        {

                            dogru++;
                        }
                        else
                        {

                            yanlis++;
                        }
                    }

                    string group = GetGroupFromFirstChar(ogrenciCevaplar[0]);
                    dataGridView1.Rows.Add(dersAdi, hocaAdi, sinavTuru, ogrenciNo, dogru, yanlis, bos, group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCorrectAnswers()
        {
                char selectedGroup = GetSelectedGroupFromComboBox();
                if (selectedGroup == ' ')
                {
                    MessageBox.Show("Lütfen geçerli bir grup seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            string dogruCevaplar = "";

            switch (selectedGroup)
            {
                case '1':
                    dogruCevaplar = textBoxA.Text.Trim();
                    break;
                case '2':
                    dogruCevaplar = textBoxA.Text.Trim() + textBoxB.Text.Trim();
                    break;
                case '3':
                    dogruCevaplar = textBoxA.Text.Trim() + textBoxB.Text.Trim() + textBoxC.Text.Trim();
                    break;
                case '4':
                    dogruCevaplar = textBoxA.Text.Trim() + textBoxB.Text.Trim() + textBoxC.Text.Trim() + textBoxD.Text.Trim();
                    break;
                default:
                    MessageBox.Show("Geçersiz grup seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
            return dogruCevaplar;
        }
        private char GetSelectedGroupFromComboBox()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                // Seçilen öğenin ilk karakterini döndür
                return comboBox1.SelectedItem.ToString()[0];
            }
            return ' '; // Hiçbir şey seçilmemişse boşluk döndür
        }

        // Method to determine group based on first character
        private string GetGroupFromFirstChar(char firstChar)
        {
            switch (firstChar)
            {
                case 'A':
                    return "Grup A";
                case 'B':
                    return "Grup B";
                case 'C':
                    return "Grup C";
                case 'D':
                    return "Grup D";
                default:
                    return "Bilinmeyen Grup";
            }
        }

        

        private int GetAnswerLengthBasedOnComboBox()
        {
            if (comboBox2.SelectedItem != null)
            {
                return Convert.ToInt32(comboBox2.SelectedItem.ToString());
            }
            return 0; // Default case if nothing is selected
        }


        private string GetSelectedSinavTuru()
        {
            if (radioButtonVize.Checked) return "Vize";
            if (radioButtonFinal.Checked) return "Final";
            if (radioButtonButunleme.Checked) return "Bütünleme";
            if (radioButton1.Checked) return "Eksınav 1";
            if (radioButton2.Checked) return "Eksınav 2";
            if (radioButton3.Checked) return "Quiz";
            return "Belirtilmedi";
        }

        // Sıfırla butonu işlemi
        private void button4_Click(object sender, EventArgs e)
        {
            DosyaYolu1 = null;
            DosyaYolu2 = null;
            label3.Visible = false;
            label3.Text = "";
            button2.Visible = true;
            textBoxDersAdi.Clear();
            textBoxHocaAdi.Clear();
            dataGridView1.Rows.Clear();
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxD.Clear();
            radioButtonVize.Checked = false;
            radioButtonFinal.Checked = false;
            radioButtonButunleme.Checked = false;

            MessageBox.Show("Tüm veriler başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Sonuçları kaydetme butonunun işlemi
        private void button5_Click(object sender, EventArgs e)
        {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sonuçlar");

                // DataGridView başlıklarını yaz
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                }

                // DataGridView verilerini yaz
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        var cellValue = dataGridView1.Rows[i].Cells[j].Value ?? string.Empty; // Null kontrolü
                        worksheet.Cell(i + 2, j + 1).Value = Convert.ToString(cellValue); // Açık dönüştürme
                    }
                }

                // Dosya kaydetme işlemi
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                    DefaultExt = "xlsx",
                    FileName = "sonuclar"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Sonuçlar başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listBoxCevapAnahtari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void labelC_Click(object sender, EventArgs e)
        {

        }
    }
}

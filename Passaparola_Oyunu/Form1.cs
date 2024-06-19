namespace PassaParola_Oyunu
{
    public partial class Form1 : Form
    {
        // Form �zerinde kullan�lacak de�i�kenlerin tan�mlanmas�
        int soruNo = 0;     // Soru numaras�
        int dogruCevaplar = 0;  // Do�ru cevap say�s�
        int yanlisCevaplar = 0; // Yanl�� cevap say�s�
        int toplamPuan = 0; // Toplam puan

        public Form1()
        {
            InitializeComponent();
        }

        // Sonraki soruya ge�mek i�in linkLabel1_LinkClicked olay�
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";   // LinkLabel metnini "Sonraki" olarak de�i�tirir
            soruNo++;   // Soru numaras�n� bir art�r�r
            this.Text = soruNo.ToString();  // Form ba�l���na g�ncel soru numaras�n� yazar

            // Sorular�n ve buton renklerinin ayarlanmas�
            switch (soruNo)
            {
                case 1:
                    richTextBox1.Text = "�lkemizin g�ney k�sm�ndaki k�y� b�lgesi?";   // RichTextBox i�ine soruyu yazar
                    btnA.BackColor = Color.Yellow;  // btnA butonunun arka plan rengini sar� yapar
                    break;
                case 2:
                    richTextBox1.Text = "Ye�illi�i ile �nl� Marmara ilimiz?";
                    btnB.BackColor = Color.Yellow;
                    break;
                case 3:
                    richTextBox1.Text = "M�sl�manlar�n Kutsal G�n�?";
                    btnC.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBox1.Text = "Karpuzu ile �nl� ilimiz?";
                    btnD.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBox1.Text = "Yeni kelimesinin z�t anlaml�s�?";
                    btnE.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBox1.Text = "Padi�ah�n emirlerinin yaz�l� hali?";
                    btnF.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBox1.Text = "D�nyan�n �s� kayna��?";
                    btnG.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBox1.Text = "��rencilerin k�t� karne getirdi�inde bak��t��� nesne?";
                    btnH.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBox1.Text = "G�l�yle �nl� ilimiz?";
                    btnI.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "Mersinin di�er ismi?";
                    btnIi.BackColor = Color.Yellow;
                    break;
                case 11:
                    richTextBox1.Text = "Askeri bir topluluk?";
                    btnJ.BackColor = Color.Yellow;
                    break;
                case 12:
                    richTextBox1.Text = "Malatyan�n me�hur meyvesi?";
                    btnK.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBox1.Text = "Her y�l bahar aylar�nda d�zenlenen me�hur �i�ek festivali?";
                    btnL.BackColor = Color.Yellow;
                    break;
                case 14:
                    richTextBox1.Text = "Y�l�n 3. Ay�?";
                    btnM.BackColor = Color.Yellow;
                    break;
                case 15:
                    richTextBox1.Text = "�flemeli bir m�zik aleti?";
                    btnN.BackColor = Color.Yellow;
                    break;
                case 16:
                    richTextBox1.Text = "Halk �airi?";
                    btnO.BackColor = Color.Yellow;
                    break;
                case 17:
                    richTextBox1.Text = "�ocuklar�n pek sevmedi�i pirin�, havu� gibi sebzeler ile yap�lan yemek?";
                    btnP.BackColor = Color.Yellow;
                    break;
                case 18:
                    richTextBox1.Text = "11 Ay�n Sultan�?";
                    btnR.BackColor = Color.Yellow;
                    break;
                case 19:
                    richTextBox1.Text = "�ngilizcede y�lan?";
                    btnS.BackColor = Color.Yellow;
                    break;
                case 20:
                    richTextBox1.Text = "T�rkiyenin megastar�?";
                    btnT.BackColor = Color.Yellow;
                    break;
                case 21:
                    richTextBox1.Text = "�mit kelimesinin e� anlaml�s�?";
                    btnU.BackColor = Color.Yellow;
                    break;
                case 22:
                    richTextBox1.Text = "Kahvalt�s� ile �nl� ilimiz?";
                    btnV.BackColor = Color.Yellow;
                    break;
                case 23:
                    richTextBox1.Text = "�im�ek kelimesinin e� anlaml�s�?";
                    btnY.BackColor = Color.Yellow;
                    break;
                case 24:
                    richTextBox1.Text = "Ege b�lgesinin en �ok a�ac� bulunan ya��da yap�lan bir besini?";
                    btnZ.BackColor = Color.Yellow;
                    break;
                default:
                    MessageBox.Show("T�m sorular bitti!");   // T�m sorular bitince bir ileti�im kutusu g�sterir
                    break;
            }
        }

        // Cevaplar�n kontrol edilmesi i�in textBox1_KeyDown olay�
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   // Enter tu�una bas�ld���nda i�lemleri yapar
            {
                string cevap = textBox1.Text.ToLower();   // TextBox i�eri�ini k���k harfe �evirir
                bool dogruMu = false;   // Cevab�n do�ru olup olmad���n� kontrol eder

                switch (soruNo)
                {
                    case 1:
                        dogruMu = cevap == "akdeniz";
                        btnA.BackColor = dogruMu ? Color.Green : Color.Red;  // Do�ru ise buton rengini ye�il yapar, de�ilse k�rm�z� yapar
                        break;
                    case 2:
                        dogruMu = cevap == "bursa";
                        btnB.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 3:
                        dogruMu = cevap == "cuma";
                        btnC.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 4:
                        dogruMu = cevap == "diyarbak�r";
                        btnD.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 5:
                        dogruMu = cevap == "eski";
                        btnE.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 6:
                        dogruMu = cevap == "ferman";
                        btnF.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 7:
                        dogruMu = cevap == "g�ne�";
                        btnG.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 8:
                        dogruMu = cevap == "hal�";
                        btnH.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 9:
                        dogruMu = cevap == "�sparta";
                        btnI.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 10:
                        dogruMu = cevap == "i�el";
                        btnIi.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 11:
                        dogruMu = cevap == "jandarma";
                        btnJ.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 12:
                        dogruMu = cevap == "kay�s�";
                        btnK.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 13:
                        dogruMu = cevap == "lale";
                        btnL.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 14:
                        dogruMu = cevap == "mart";
                        btnM.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 15:
                        dogruMu = cevap == "ney";
                        btnN.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 16:
                        dogruMu = cevap == "ozan";
                        btnO.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 17:
                        dogruMu = cevap == "p�rasa";
                        btnP.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 18:
                        dogruMu = cevap == "ramazan";
                        btnR.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 19:
                        dogruMu = cevap == "snake";
                        btnS.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 20:
                        dogruMu = cevap == "tarkan";
                        btnT.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 21:
                        dogruMu = cevap == "umut";
                        btnU.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 22:
                        dogruMu = cevap == "van";
                        btnV.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 23:
                        dogruMu = cevap == "y�ld�r�m";
                        btnY.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 24:
                        dogruMu = cevap == "zeytinya��";
                        btnZ.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                }

                // Do�ru veya yanl�� cevaplar�n say�s�n� g�ncelle
                if (dogruMu)
                {
                    dogruCevaplar++;    // Do�ru cevap say�s�n� bir art�r�r
                    toplamPuan += 3;    // Do�ru cevap i�in 3 puan ekler
                }
                else
                {
                    yanlisCevaplar++;   // Yanl�� cevap say�s�n� bir art�r�r
                    toplamPuan -= 1;    // Yanl�� cevap i�in 1 puan ��kar�r
                }

                // G�ncel do�ru ve yanl�� cevap say�lar�n� ve toplam puan� g�ster
                lblDogru.Text = $"{dogruCevaplar}";   // Label i�ine do�ru cevap say�s�n� yazar
                lblYanlis.Text = $"{yanlisCevaplar}";   // Label i�ine yanl�� cevap say�s�n� yazar
                btnToplam.Text = $"Puan: {toplamPuan}";  // btnToplamda butonunun metnini toplam puan olarak g�nceller

                textBox1.Clear();   // TextBox i�eri�ini temizler
            }
        }
    }
}

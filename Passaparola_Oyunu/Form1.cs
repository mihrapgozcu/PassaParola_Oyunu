namespace PassaParola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            // Sorular ve buton renklerini ayarlama
            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "Ülkemizin güney kýsmýndaki kýyý bölgesi?";
                    btnA.BackColor = Color.Yellow;
                    break;
                case 2:
                    richTextBox1.Text = "Yeþilliði ile ünlü Marmara ilimiz?";
                    btnB.BackColor = Color.Yellow;
                    break;
                case 3:
                    richTextBox1.Text = "Müslümanlarýn Kutsal Günü?";
                    btnC.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                    btnD.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBox1.Text = "Yeni kelimesinin zýt anlamlýsý?";
                    btnE.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBox1.Text = "Padiþahýn emirlerinin yazýlý hali?";
                    btnF.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBox1.Text = "Dünyanýn ýsý kaynaðý?";
                    btnG.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBox1.Text = "Öðrencilerin kötü karne getirdiðinde bakýþtýðý nesne?";
                    btnH.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                    btnI.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "Mersinin diðer ismi?";
                    btnIi.BackColor = Color.Yellow;
                    break;
                case 11:
                    richTextBox1.Text = "Askeri bir topluluk?";
                    btnJ.BackColor = Color.Yellow;
                    break;
                case 12:
                    richTextBox1.Text = "Malatyanýn meþhur meyvesi?";
                    btnK.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBox1.Text = "Her yýl bahar aylarýnda düzenlenen meþhur çiçek festivali?";
                    btnL.BackColor = Color.Yellow;
                    break;
                case 14:
                    richTextBox1.Text = "Yýlýn 3. Ayý?";
                    btnM.BackColor = Color.Yellow;
                    break;
                case 15:
                    richTextBox1.Text = "Üflemeli bir müzik aleti?";
                    btnN.BackColor = Color.Yellow;
                    break;
                case 16:
                    richTextBox1.Text = "Halk þairi?";
                    btnO.BackColor = Color.Yellow;
                    break;
                case 17:
                    richTextBox1.Text = "Çocuklarýn pek sevmediði pirinç, havuç gibi sebzeler ile yapýlan yemek?";
                    btnP.BackColor = Color.Yellow;
                    break;
                case 18:
                    richTextBox1.Text = "11 Ayýn Sultaný?";
                    btnR.BackColor = Color.Yellow;
                    break;
                case 19:
                    richTextBox1.Text = "Ýngilizcede yýlan?";
                    btnS.BackColor = Color.Yellow;
                    break;
                case 20:
                    richTextBox1.Text = "Türkiyenin megastarý?";
                    btnT.BackColor = Color.Yellow;
                    break;
                case 21:
                    richTextBox1.Text = "Ümit kelimesinin eþ anlamlýsý?";
                    btnU.BackColor = Color.Yellow;
                    break;
                case 22:
                    richTextBox1.Text = "Kahvaltýsý ile ünlü ilimiz?";
                    btnV.BackColor = Color.Yellow;
                    break;
                case 23:
                    richTextBox1.Text = "Þimþek kelimesinin eþ anlamlýsý?";
                    btnY.BackColor = Color.Yellow;
                    break;
                case 24:
                    richTextBox1.Text = "Ege bölgesinin en çok aðacý bulunan yaðýda yapýlan bir besini?";
                    btnZ.BackColor = Color.Yellow;
                    break;
                default:
                    MessageBox.Show("Tüm sorular bitti!");
                    break;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cevap = textBox1.Text.ToLower();
                bool dogruMu = false;

                switch (soruno)
                {
                    case 1:
                        dogruMu = cevap == "akdeniz";
                        btnA.BackColor = dogruMu ? Color.Green : Color.Red;
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
                        dogruMu = cevap == "diyarbakýr";
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
                        dogruMu = cevap == "güneþ";
                        btnG.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 8:
                        dogruMu = cevap == "halý";
                        btnH.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 9:
                        dogruMu = cevap == "ýsparta";
                        btnI.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 10:
                        dogruMu = cevap == "içel";
                        btnIi.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 11:
                        dogruMu = cevap == "jandarma";
                        btnJ.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 12:
                        dogruMu = cevap == "kayýsý";
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
                        dogruMu = cevap == "pýrasa";
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
                        dogruMu = cevap == "yýldýrým";
                        btnY.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                    case 24:
                        dogruMu = cevap == "zeytinyaðý";
                        btnZ.BackColor = dogruMu ? Color.Green : Color.Red;
                        break;
                }

                if (dogruMu)
                {
                    dogru++;
                    label2.Text = dogru.ToString();
                }
                else
                {
                    yanlis++;
                    label4.Text = yanlis.ToString();
                }

                // TextBox içeriðini temizle
                textBox1.Clear();
            }
        }
    }
}

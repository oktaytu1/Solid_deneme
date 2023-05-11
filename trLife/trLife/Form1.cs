using static System.Net.Mime.MediaTypeNames;

namespace trLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------sýnýflarý nesne yapma---------------------------------------
        public Oyun oyun = new Oyun();
        public Kullanici kullanici = new Kullanici();
        public Method metod = new Method();
        //---------------------------------------sýnýflarý nesne yapma---------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_rastgeleIsim_Click(object sender, EventArgs e)//ismi rastgele veriyor
        {
            int a = oyun.rnd.Next(0, 10);//rastgele sayý üretiliyor

            if (kullanici.cinsiyetErkek)//cinsiyet erkek ise
            {txt_isim.Text = oyun.isimler_erkek[a];}

            else//cinsiyet kýz ise
            {txt_isim.Text = oyun.isimler_kiz[a];}

        }

        private void radioBtn_cinsiyetErkek_CheckedChanged(object sender, EventArgs e)//cinsiyet seçiliyor
        {
            if (radioBtn_cinsiyetErkek.Checked==true)//erkek radio buton seçildiyse
            {kullanici.cinsiyetErkek = true;}

            else//kýz radio buton seçildiyse
            { kullanici.cinsiyetErkek = false;}
        }

        private void btn_oyunaBasla_Click(object sender, EventArgs e)//buna basýnca oyun baþlýyor
        {
            if (txt_isim.Text=="")//bir isim girilmemiþse
            {MessageBox.Show("Bir isim giriniz!");}


            else//isim girilmiþse
            {
                if (radioBtn_duzInsan.Checked==true)//doðuþtan gelen yetenk seçilmemiþse
                { MessageBox.Show("Bir yetenek seçiniz!"); }

                else//yetenek seçildiyse
                {
                    //seçilen yeteneði kaydet
                    metod.baslangic_yetenekBelirle(radioBtn_yetenek0, radioBtn_yetenek1, radioBtn_yetenek2, radioBtn_yetenek3, radioBtn_yetenek4);


                    //-----kullanýcý cinsiyeti-----
                    if (radioBtn_cinsiyetErkek.Checked==true)//cinsiyet erkek seçilmiþ ise
                    {
                        kullanici.cinsiyetErkek = true;
                    }
                    else//cinsiyet kýz seçilmiþ ise
                    {
                        kullanici.cinsiyetErkek = false;
                    }
                    //-----kullanýcý cinsiyeti-----

                    kullanici.isim = txt_isim.Text;
                    lbl_isim.Text = kullanici.isim;

                    kullanici.memleket = oyun.sehirler[oyun.rnd.Next(0,80)];//kullanici memleketi rastgele belirleniyor
                    lbl_memleket.Text = kullanici.memleket;

                    kullanici.yas++;

                    //kullanýcý deðerleri belirleniyor ve gösteriliryor
                    metod.baslangic_progresDoldur(progresB_saglik,progresB_mental,progresB_enerji);
                    metod.baslangic_oranBelirle(lbl_yetenek0,lbl_yetenek1,lbl_yetenek2,lbl_yetenek3,lbl_yetenek4);


                    MessageBox.Show(kullanici.isim + ", " + kullanici.memleket + " þehrinde doðdu.");
                    metod.oyun_bebekÝlkText(lbl_oyunBebek);
                }

            }


        }

        private void radioBtn_yetenek0_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_yetenek0.Checked==true)
            {
                kullanici.yetenek = oyun.butunYetenekler[0];
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metod.oyun_bebekKomut(lbl_oyunBebek,progresB_saglik,progresB_mental);
        }
    }
}
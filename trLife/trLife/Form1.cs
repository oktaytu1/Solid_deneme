using static System.Net.Mime.MediaTypeNames;

namespace trLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------s�n�flar� nesne yapma---------------------------------------
        public Oyun oyun = new Oyun();
        public Kullanici kullanici = new Kullanici();
        public Method metod = new Method();
        //---------------------------------------s�n�flar� nesne yapma---------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_rastgeleIsim_Click(object sender, EventArgs e)//ismi rastgele veriyor
        {
            int a = oyun.rnd.Next(0, 10);//rastgele say� �retiliyor

            if (kullanici.cinsiyetErkek)//cinsiyet erkek ise
            {txt_isim.Text = oyun.isimler_erkek[a];}

            else//cinsiyet k�z ise
            {txt_isim.Text = oyun.isimler_kiz[a];}

        }

        private void radioBtn_cinsiyetErkek_CheckedChanged(object sender, EventArgs e)//cinsiyet se�iliyor
        {
            if (radioBtn_cinsiyetErkek.Checked==true)//erkek radio buton se�ildiyse
            {kullanici.cinsiyetErkek = true;}

            else//k�z radio buton se�ildiyse
            { kullanici.cinsiyetErkek = false;}
        }

        private void btn_oyunaBasla_Click(object sender, EventArgs e)//buna bas�nca oyun ba�l�yor
        {
            if (txt_isim.Text=="")//bir isim girilmemi�se
            {MessageBox.Show("Bir isim giriniz!");}


            else//isim girilmi�se
            {
                if (radioBtn_duzInsan.Checked==true)//do�u�tan gelen yetenk se�ilmemi�se
                { MessageBox.Show("Bir yetenek se�iniz!"); }

                else//yetenek se�ildiyse
                {
                    //se�ilen yetene�i kaydet
                    metod.baslangic_yetenekBelirle(radioBtn_yetenek0, radioBtn_yetenek1, radioBtn_yetenek2, radioBtn_yetenek3, radioBtn_yetenek4);


                    //-----kullan�c� cinsiyeti-----
                    if (radioBtn_cinsiyetErkek.Checked==true)//cinsiyet erkek se�ilmi� ise
                    {
                        kullanici.cinsiyetErkek = true;
                    }
                    else//cinsiyet k�z se�ilmi� ise
                    {
                        kullanici.cinsiyetErkek = false;
                    }
                    //-----kullan�c� cinsiyeti-----

                    kullanici.isim = txt_isim.Text;
                    lbl_isim.Text = kullanici.isim;

                    kullanici.memleket = oyun.sehirler[oyun.rnd.Next(0,80)];//kullanici memleketi rastgele belirleniyor
                    lbl_memleket.Text = kullanici.memleket;

                    kullanici.yas++;

                    //kullan�c� de�erleri belirleniyor ve g�steriliryor
                    metod.baslangic_progresDoldur(progresB_saglik,progresB_mental,progresB_enerji);
                    metod.baslangic_oranBelirle(lbl_yetenek0,lbl_yetenek1,lbl_yetenek2,lbl_yetenek3,lbl_yetenek4);


                    MessageBox.Show(kullanici.isim + ", " + kullanici.memleket + " �ehrinde do�du.");
                    metod.oyun_bebek�lkText(lbl_oyunBebek);
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
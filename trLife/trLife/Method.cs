using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trLife
{
    public class Method 
    {
        public Kullanici kullanici = new Kullanici();
        public Oyun oyun = new Oyun();
        public Hayat hayat = new Hayat();
        public Hayat anne = new Hayat();
        public Hayat baba = new Hayat();


        public void baslangic_progresDoldur(ProgressBar a, ProgressBar b, ProgressBar c)//progressbar değerlerini dolduruyor
        {
            kullanici.saglik = oyun.rnd.Next(50, 100);
            kullanici.mental = oyun.rnd.Next(50, 100);
            kullanici.enerji = oyun.rnd.Next(50, 100);
            a.Value = kullanici.saglik;
            b.Value = kullanici.mental;
            c.Value = kullanici.enerji;
        }

        public void baslangic_yetenekBelirle(RadioButton a, RadioButton b, RadioButton c, RadioButton d, RadioButton e)//radiobtn da seçilen yetenek kayıt ediliyor
        {
            if (a.Checked == true)
            {
                kullanici.yetenek = oyun.butunYetenekler[0];
            }
            if (b.Checked == true)
            {
                kullanici.yetenek = oyun.butunYetenekler[1];
            }
            if (c.Checked == true)
            {
                kullanici.yetenek = oyun.butunYetenekler[2];
            }
            if (d.Checked == true)
            {
                kullanici.yetenek = oyun.butunYetenekler[3];
            }
            if (e.Checked == true)
            {
                kullanici.yetenek = oyun.butunYetenekler[4];
            }
        }

        public void baslangic_oranBelirle(Label a, Label b, Label c, Label d, Label e)//şans vs. gibi değerleri veriyor
        {
            a.Text = oyun.rnd.Next(40,60).ToString();
            b.Text = oyun.rnd.Next(40, 60).ToString();
            c.Text = oyun.rnd.Next(40, 60).ToString();
            d.Text = oyun.rnd.Next(40, 60).ToString();
            e.Text = oyun.rnd.Next(40, 60).ToString();

            switch (kullanici.yetenek)
            {
                case ("Hızlı"):
                    a.Text = (Convert.ToInt16(a.Text) + 20).ToString();
                    break;
                case ("Güçlü"):
                    b.Text = (Convert.ToInt16(b.Text) + 20).ToString();
                    break;
                case ("Zeki"):
                    c.Text = (Convert.ToInt16(c.Text) + 20).ToString();
                    break;
                case ("Çekici"):
                    d.Text = (Convert.ToInt16(d.Text) + 20).ToString();
                    break;
                case ("Şanslı"):
                    e.Text = (Convert.ToInt16(e.Text) + 20).ToString();
                    break;
            }
        }

        public void oyun_bebekİlkText(Label a)//bebeğin ilk konuşması
        {
            string text = "Hayata geldin. ";
            switch (oyun.rnd.Next(0, 3))
            {
                case (0):
                    text += "Anne baban sevinçle seni izliyor. ";
                    break;
                case (1):
                    text += "Sülalen çok kalabalık, etrafın sana bakan akrabalarla dolu. ";
                    break;
            }
            text += "\n" + "Ne yapacaksın?";
            a.Text = text;
        }

        public void oyun_bebekKomut(Label a, ProgressBar pbcan, ProgressBar pbmental) 
        {
            hayat.mood = oyun.rnd.Next(0, 3);
            anne.mood = oyun.rnd.Next(0, 3);
            baba.mood = oyun.rnd.Next(0, 3);


            switch (hayat.mood)
            {
                case(1):
                    hayat.genel_tepki = "Bu yaptığın keyfini yerine getirdi!\n";
                    if (kullanici.mental+10<100)
                    {
                        kullanici.mental += 10;
                        pbmental.Value = kullanici.mental;
                    }
                    break;
                case (2):
                    hayat.genel_tepki = "Bunu yaparken kendini yaraladın!\n";
                    if (kullanici.saglik - 10 > 0)
                    {
                        kullanici.saglik -= 10;
                        pbcan.Value = kullanici.saglik;
                    }
                    else
                    {
                        hayat.genel_tepki += "Öldün! ";
                        pbcan.Value = 0;

                    }
                    break;
            }
            a.Text = hayat.genel_tepki;


            for (int i = 0; i < hayat.anne_tepki.Length; i++)
            {
                if (anne.mood==i)
                {
                    hayat.genel_tepki = hayat.anne_tepki[i];
                }
            }
            a.Text += hayat.genel_tepki;

            for (int i = 0; i < hayat.baba_tepki.Length; i++)
            {
                if (baba.mood == i)
                {
                    hayat.genel_tepki = hayat.baba_tepki[i];
                }
            }
            a.Text += hayat.genel_tepki;

        }
    }
}

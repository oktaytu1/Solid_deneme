using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trLife
{
    public class Oyun
    {   //---------------------------------------oyun içinde gerekecek değişkenleri---------------------------------------

        public string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce" };
        public string[] isimler_erkek = { "Ahmet", "Mehmet", "Ali", "Hasan", "Hüseyin", "İbrahim", "Mustafa", "Osman", "Yusuf", "Ömer" };
        public string[] isimler_kiz = { "Ayşe", "Fatma", "Zeynep", "Emine", "Esra", "Hatice", "İpek", "Nur", "Seda", "Yasemin" };

        public int[] butunYetenekler = { 0, 1, 2, 3, 4 };
        //0=fiziksel  1=yetenek  2=zeki  3=sosyal  4=şans


        public string[] butunPetler = { "Kedi", "Köpek", "Hamster", "Kuş", "Tilki" };

        public Random rnd = new Random();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trLife
{
    public class Hayat
    {
        Oyun oyun = new Oyun();

        public int mood;
        //0=nötr - 1=iyi - 2=kötü

        public string genel_tepki;

        public string[] anne_tepki = { "", "Annen bu yaptığına çok mutlu oldu.\n", "Bunu yaparak anneni çok üzdün.\n" };
        public string[] baba_tepki = { "", "Baban bu yaptığına çok mutlu oldu.\n", "Bunu yaparak babanı çok üzdün.\n" };

    }
}

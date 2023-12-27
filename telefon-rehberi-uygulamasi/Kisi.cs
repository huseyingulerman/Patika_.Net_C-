using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefon_rehberi_uygulamasi
{
    public class Kisi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }

        public Kisi(string isim, string soyisim, string telefon)
        {
            Isim = isim;
            Soyisim = soyisim;
            Telefon = telefon;
        }
    }
}

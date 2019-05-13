using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class SubeSingleton
    {
        private string subeadi;
        public string Subeler { get { return subeadi; } set { subeadi = value; } }

        private List<OgretimUye> ogretimuyeler = new List<OgretimUye>();

        public List<OgretimUye> OgretimUyeler { get { return ogretimuyeler; } set { ogretimuyeler = value; } }
        public void OgretimUyeEkle(OgretimUye z)
        {
            ogretimuyeler.Add(z);

        }
        public void OgretimUyeListele()
        {
            foreach(OgretimUye z in ogretimuyeler)
            {

                Console.WriteLine(z.OgrAdi+"\t"+z.Gorevlino);


            }
        }
        private SubeSingleton()
        {
            //Kullanıcının nesne yaratmasını engelliyoruz,yaratmaya çalıştıgında ise hata alacak.
        }

        private static SubeSingleton subenesnesi;

        public static SubeSingleton NesneVer()
        {
            if (subenesnesi==null)
            {
                subenesnesi = new SubeSingleton();
            }
            return subenesnesi;
            //Kontrollü bir sekilde kullanıcıya 1 nesne yolluyoruz metod her çağırıldığında her seferinde sabit subenesnesi dönecek.
            
        }

    

    }



}

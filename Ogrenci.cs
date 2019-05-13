using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    abstract class Ogrenci
    {
       protected string adi;
       protected int no;
       protected string soyadi;


        public Ogrenci(string Adi,string Soyadi,int No )
        {
            this.adi = Adi;
            this.no = No;
            this.soyadi = Soyadi;

        }
        
        public string Adi { get { return adi; } set { adi = value; }  }
        public string Soyad { get { return soyadi; } set { soyadi = value; } }
        public int No { get { return no; } set { no = value; } }
        public override string ToString()
        {
            return $"Ad:{adi} Soyad:{soyadi} No:{no} Tip:{this.GetType().Name}";
        }


    }
    class YuksekLisans : Ogrenci
    {
        public YuksekLisans(string adi, string soyadi, int no) : base(adi, soyadi, no)
        {
            //Yukseklisans yapılandırıcısı.
        }
    }
    class Doktora:Ogrenci
    {
        public Doktora(string adi, string soyadi, int no) : base(adi, soyadi, no)
        {
            //Doktora yapılandırıcısı.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace Odev2
{
    class Ders
    { 
       private string dersadi;
       private int derskodu;

        public string Dersadi { get { return dersadi; } set { dersadi = value; } }
        public int DersKodu { get { return derskodu; } set { derskodu = value; } }

        private List<Ogrenci> ogrenciler2= new List<Ogrenci>();
        
        public List<Ogrenci> Ogrencilerlistesi {get { return ogrenciler2; } set { ogrenciler2 = value; } }

        public Ders(string Dersadi,int Derskodu)
        {
            this.dersadi = Dersadi;
            this.derskodu = Derskodu;
        }
        public void OgrenciEkle(Ogrenci z)
        {

            ogrenciler2.Add(z);
        }
        public void OgrenciListele()
        {
            foreach (Ogrenci z in ogrenciler2)
            {

                Console.WriteLine(z.ToString());


            }
        }

        public Ogrenci OgrenciAra(string Adi)
        {
            Ogrenci t = null;
            foreach (Ogrenci b in ogrenciler2)
            {
                if (string.Equals(b.Adi, Adi))
                {
                    t = b;
                    Console.WriteLine(Adi + " Adlı ogrenci vardir");
                }

            }
            if (t == null) { Console.WriteLine(Adi+" Adlı ogrenci yoktur"); }
            return t;
        }
        public Ogrenci OgrenciAra(int No)
        {
            Ogrenci w = null;
            foreach(Ogrenci a in ogrenciler2)
            {
                if (int.Equals(a.No, No)){
                    w = a;
                    Console.WriteLine(No + " nolu ogrenci vardir");
                }
            }
            if (w == null) { Console.WriteLine(No+" Nolu ogrenci yoktur"); }
            return w;
        }
        public void OgrenciSil(int y)
        {
            

            foreach (Ogrenci b in ogrenciler2.ToList())
            {
                if(y == b.No)
                {
                    ogrenciler2.Remove(b);
                    Console.WriteLine(y + "numaralı ogrenci cikarildi.");

                }
                Console.WriteLine(y + "numaralı ogrenci bulunamadi.");
            }

            
        }
        public void Yazdir()
        {
            //Bir txt dosyasina yazdirma islemi
            StreamWriter yaz = new StreamWriter("ogrenciler.txt");
            foreach (Ogrenci x in ogrenciler2)
            {

                yaz.WriteLine(x.ToString());



            }
             yaz.Close();

        }


    }


    class Universite
    {
        private string uniadi;
        public string Uniadi { get { return uniadi; } set{ uniadi = value;} }

        private List<Fakulte> fakultelistesi = new List<Fakulte>();

        public List<Fakulte> Fakulteler { get { return fakultelistesi; } set { fakultelistesi = value; } }


        public Universite(string name)
        {
            this.uniadi = name;
            //fakultelistesi.Add(Fakulte z);

            
        }

        public void FakulteEkle(Fakulte z)
        {
            fakultelistesi.Add(z);

        }


        public void FakulteListele()
        {
            Console.WriteLine("Fakulteler:\n");
            foreach (Fakulte x in fakultelistesi )
            {
                Console.WriteLine(x.FakulteIsmi+"\n");
            }

        }

        
    }

    class Fakulte
    {
        private string fakulteadi;
        public string FakulteIsmi { get { return fakulteadi; } set { fakulteadi = value; } }

        public Fakulte(string Fakulteadi)
        {
            this.fakulteadi = Fakulteadi;
        }
    
     
        private List<Bolum> bolumler = new List<Bolum>();

        public List<Bolum> Bolumler { get { return bolumler; } set { bolumler = value; } }
        
        public void BolumEkle(Bolum x)
        {
            bolumler.Add(x);

        }

    }
    class Bolum
    {
        private string bolumadi;
        public string Bolumler { get { return bolumadi; } set { bolumadi = value; } }

        private List<SubeSingleton> subeler = new List<SubeSingleton>();

        private List<Ogrenci> ogrenciler = new List<Ogrenci>();

        private List<Ders> dersler = new List<Ders>();

        public List<Ders> Dersler { get { return dersler; } set { dersler = value; } }
        public List<Ogrenci> Ogrenciler2 { get { return ogrenciler; } set { ogrenciler = value; } }

        public List<SubeSingleton> Subeler { get { return subeler; } set { subeler = value; } }

        public void DersEkle(Ders z)
        {
            dersler.Add(z);
        }
        public Bolum(string Bolumadi)
        {
            this.bolumadi = Bolumadi;
                
        }
        public void SubeEkle(SubeSingleton z)
        {
            subeler.Add(z);
        }
       
        public void OgrenciListele()
        {
            foreach (Ogrenci z in ogrenciler)
            {

                Console.WriteLine(z.ToString());


            }
        }
       
    }

    class OgretimUye
    {
        private string adi;

        private int gorevlino;
    
        public int Gorevlino { get { return gorevlino; } set { gorevlino = value; } }   
        //Her deste baska ögretim görevlisi olabilir.
        private Dictionary<string, int> ogretimuyeders = new Dictionary<string, int>();
        public Dictionary<string, int> Ogretimuye { get { return ogretimuyeders; } set { ogretimuyeders = value; } }

        public string OgrAdi { get { return adi; } set { adi = value; } }
        public OgretimUye(string name,int no)
        {
            this.adi = name;
            this.gorevlino = no;
        }

        

    }
}



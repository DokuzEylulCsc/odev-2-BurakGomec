using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Odev2
{
    class Program
    {
        

        static void Main(string[] args)
        {

            
            Universite dokuzeyl = null;
            string uniadi = "dokuzeyl";
            dokuzeyl = new Universite(uniadi);
            dokuzeyl.FakulteEkle(new Fakulte("Edebiyat"));
            dokuzeyl.FakulteEkle(new Fakulte("Fen"));
            dokuzeyl.FakulteEkle(new Fakulte("Muhendislik"));
            dokuzeyl.Fakulteler[0].BolumEkle(new Bolum("Sosyoloji"));
            dokuzeyl.Fakulteler[0].BolumEkle(new Bolum("Psikoloji"));
            dokuzeyl.Fakulteler[1].BolumEkle(new Bolum("Bilgisayar Bilimleri"));
            dokuzeyl.Fakulteler[2].BolumEkle(new Bolum("Yazilim Muhendisligi"));
            
            //Fakulte,bolum,dersi el ile acılıyor burada.
            
            dokuzeyl.Fakulteler[0].Bolumler[0].DersEkle(new Ders("Görsel programlama dilleri",2001));
            dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciEkle(new YuksekLisans("Burak", "Gomec", 2322));
            dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciEkle(new YuksekLisans("Cem", "Kocabiyik", 556));
            dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciEkle(new YuksekLisans("Can", "Saracoglu", 556));

            SubeSingleton sube = SubeSingleton.NesneVer(); //Tek bir nesne değeri

            sube.OgretimUyeEkle(new OgretimUye("Cem", 5553));
            sube.OgretimUyeEkle(new OgretimUye("Mehmet", 32));
            //Singleton oldugundan dolayı sube objesi bir yere bağlanmadi.
            string flag = "1";
            
            while (flag == "1")
            {
                Console.WriteLine("Öğrenci Kayit icin 1 e basiniz \nÖgrenci silmek icin 2 ye basiniz \nÖgrencileri dosyaya kaydetmek icin 3 e basiniz\n" +
                "Ögrenci listemek icin 4 e basiniz\nÖgrenci aramak icin 5 e basiniz\nFakulte listelemek 6 ya basin\nÖğretimUyesi Listelemek icin 7 e basin\n");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Ogrencinin adini giriniz");
                            string ogrenciadi = Console.ReadLine();
                            Console.WriteLine("Ogrencinin soyadini giriniz:");
                            string ogrencisoyadi = Console.ReadLine();
                            Console.WriteLine("Ogrencinin numarasini giriniz:");
                            int ogrencino = Convert.ToInt32(Console.ReadLine());
                            dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciEkle(new YuksekLisans(ogrenciadi, ogrencisoyadi, ogrencino));
                            
                        }
                        catch(FormatException)
                        {
                            //Giriş formatı($,#) girildiğinde yakalaması için catch yapisi.
                            Console.WriteLine("Giriş dizesi doğru değil!(Format Exception)");
                        }
                        
                        catch(Exception)
                        {
                            //En genel hata yakalıyor.
                            Console.WriteLine("Hata");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Silinecek öğrencinin numarasini giriniz");
                        int sil = Convert.ToInt32(Console.ReadLine());
                        dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciSil(sil);
                        break;
                    case 3:
                        dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].Yazdir();
                        Console.WriteLine("\nTxt dosyasina basariyla yazdirildi!");
                        break;
                    case 4:
                        dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciListele();
                        break;
                    case 5:
                        //İsime göre veya numaraya göre arama commentler düzeltilerek calisabilir.
                        Console.WriteLine("Aranacak numarasini/adini giriniz:");
                        int ara = Convert.ToInt32(Console.ReadLine());
                        //string arama= Convert.ToString(Console.ReadLine());
                        //İsime ve numaraya göre arama.
                        dokuzeyl.Fakulteler[0].Bolumler[0].Dersler[0].OgrenciAra(ara);
                        //dersler.OgrenciAra(arama);
                        break;
                    case 6:
                        Console.WriteLine("Fakulteler listeleniyor:\n");
                        dokuzeyl.FakulteListele();
                        break;
                    case 7:
                        Console.WriteLine("Ogretimuyeleri listeleniyor:\n");
                        sube.OgretimUyeListele();
                        break;
                    default:
                        Console.Write("Yanlis tus girdiniz.");
                        break;
                        

                }
                Console.WriteLine("Devam etmek icin 1 e basin bitirmek icin hergangi bir tus(0) basin");
                flag =(Console.ReadLine());

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKonusuConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sepet<string> isimlerSepeti = new Sepet<string>();
            //Sepet<int> integerSepeti = new Sepet<int>();
            //Sepet<DateTime> tarihlerSepeti = new Sepet<DateTime>();

            //List<string> ogrencilerinIsimleri = new List<string>();

            //Sonuc<Ogrenci> ogr1Sonucu = new Sonuc<Ogrenci>();
            //Ogrenci ogr1 = new Ogrenci();
            //ogr1.Ad = "Birkan";
            //ogr1.Soyad = "Varan";

            //ogr1Sonucu.Data = ogr1;

            SonucDevam<Ogrenci, char, string> sncdvm1 = new SonucDevam<Ogrenci, char, string>();
            Ogrenci ogr2 = new Ogrenci()
            {
                Ad = "Hayri",
                Soyad = "Akşan"
            };

            sncdvm1.Data = ogr2;
            sncdvm1.Basarili = 'E';
            sncdvm1.Mesaj = "Bu Hayri'nin mesajıdır.";

            SonucDevam<Kisi, bool, char[]> sncdvm2 = new SonucDevam<Kisi, bool, char[]>();
            Kisi k1 = new Kisi()
            {
                Ad = "Nalan",
                Soyad = "Koroğlu"
            };

            sncdvm2.Data = k1;
            sncdvm2.Basarili = true;
            char[] mesajDizisi = new char[7] { 'M', 'e', 'r', 'h', 'a', 'b', 'a' };
            sncdvm2.Mesaj = mesajDizisi;

            Console.ReadKey();

            SonucDevamEtsin<Ogrenci, Ogretmen> sncdvm3 = new SonucDevamEtsin<Ogrenci, Ogretmen>();

            Ogretmen ogretmen1 = new Ogretmen()
            {
                Ad = "Devrim",
                Soyad = "Akçora Bozan"
            };

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Betül";
            ogrenci1.Soyad = "Akşan";

            sncdvm3.Tip1 = ogrenci1;
            sncdvm3.Tip2 = ogretmen1;
            



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Models;
using Uygulama.Models.Interface;

namespace Uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Seçim Yapınız. Öğrenci(1), Öğretmen(2)");
            int secim =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz. Listele(1), Yeni Ekle(2)");
            int islem = Convert.ToInt32(Console.ReadLine());
           
            if (secim == 1)
            {
                ISql<Ogrenci> sql = new Ogrenci();
                if (islem==1)
                {
                    sql.Listele();
                }
                else
                {
                    Ogrenci ogr = new Ogrenci { AdSoyad = "test" };
                    sql.Ekle(ogr);
                }
            }
            else
            {
                ISql<Ogretmen> sql = new Ogretmen();
                if (islem==1)
                {
                    sql.Listele();
                }
                else
                {
                    Ogretmen ogrt = new Ogretmen { AdSoyad = "test", MaasBeklentisi = 2400 };
                    sql.Ekle(ogrt);
                }
            }
        }
    }
}

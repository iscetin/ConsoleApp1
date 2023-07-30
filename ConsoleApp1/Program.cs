using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            
            
            
            SepetManager sepetManager = new SepetManager();



            sepetManager.Ekle(new Urun {Adi="Elma",Aciklama="Yeşil Elma",ID=1,StokAdedi=20,Fiyat1=25.99});
            sepetManager.Ekle2(new Urun { Uretici = "İsmail", Adi = "Elma", Aciklama = "Amasya", StokAdedi = 20,Fiyat1=24.99 });

            Console.ReadLine();

        }
    }
}

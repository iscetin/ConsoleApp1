using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(urun.Adi +" - "+ urun.Aciklama+" - "+urun.Fiyat1+" - "+urun.StokAdedi);

        }

        public void Ekle2(Urun urun)
        {
            Console.WriteLine(urun.Adi+"-"+urun.Aciklama+"-"+urun.Uretici);
        }

    }
}

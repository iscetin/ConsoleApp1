using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public double Fiyat1 { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }
        public string Uretici { get; set; }
    }
}

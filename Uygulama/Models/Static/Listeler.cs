using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Models.Static
{
    internal static class Listeler
    {
        public static List<Ogrenci> Ogrenciler { get; set; } = new List<Ogrenci>();
        public static List<Ogretmen> Ogretmenler { get; set; } = new List<Ogretmen>();
    }
}

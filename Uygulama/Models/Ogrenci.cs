using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Models.Abstract;
using Uygulama.Models.Interface;
using Uygulama.Models.Static;

namespace Uygulama.Models
{
    internal class Ogrenci : ModelBase, ISql<Ogrenci>
    {
        public void Ekle(Ogrenci model)
        {
            Listeler.Ogrenciler.Add(model);
        }

        public List<Ogrenci> Listele()
        {
            return Listeler.Ogrenciler;
        }
    }
}

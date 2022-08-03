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
    internal class Ogretmen : ModelBase, ISql<Ogretmen>
    {
        public int MaasBeklentisi { get; set; }

        public void Ekle(Ogretmen model)
        {
            Listeler.Ogretmenler.Add(model);
        }

        public List<Ogretmen> Listele()
        {
            return Listeler.Ogretmenler;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Models.Interface
{
    internal interface ISql<T> where T : class
    {
        void Ekle(T model);
        List<T> Listele();
    }
}

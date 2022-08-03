using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama.Models.Abstract
{
    internal abstract class ModelBase
    {
        public int Id { get; set; }
        public String AdSoyad { get; set; }
    }
}

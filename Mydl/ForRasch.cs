using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Mydl
{
    public class ForRasch
    {
        public static double Raschet(double percentMaterial, double percentProduct, decimal kolvo, decimal dlina, decimal shirina)
        {
            return (double)shirina * (double)dlina * percentMaterial * (double)kolvo * percentProduct;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKonusuConsoleApp
{
    public class SonucDevamEtsin<T1, T2> where T1 : class where T2 : class
    {
        public T1 Tip1 { get; set; }
        public T2 Tip2 { get; set; }
    }
}

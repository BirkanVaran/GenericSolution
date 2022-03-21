using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKonusuConsoleApp
{
    public class SonucDevam<TData, TBasarili, TMesaj> where TData : class
    {
        // SonucDevam isimli Class Generic yapıya dönüştürüldü.
        // SonucDevam isimli Class Generic yapısında birden çok tip alabildi.
        // SonucDevam isimli Class Generic yapısındaki parametlerinden sadece TData için Class istiyor. Diğerleri c#'a ait tipleri kabul eder.
        public TMesaj Mesaj { get; set; }
        public TBasarili Basarili { get; set; }
        public TData Data { get; set; }
    }
}

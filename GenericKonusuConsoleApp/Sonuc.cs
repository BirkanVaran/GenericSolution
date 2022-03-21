using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKonusuConsoleApp
{
    public class Sonuc<T> where T: class
    {
        // Tip olarak sadece Class'ları almaya izin verelim.
        // Bunu Where T : class koşulunu yazarak Class'ın generic yapısına verilecek olan tipi sınırlandırdık.
        // Where T : class yazmadan önce string, int, DateTime, ConsoleColor, int vb. c# dilinde tipleri T olarak verebiliyorduk.
        // Ama şu anda Where T: Class yazarak sadece c# uygulamanızda class olarak tanımladıklarınız bu generic class'a tip olarak verilebilirler / atanabilirler.
        public string Mesaj { get; set; }
        public string Basarili { get; set; } 
        public T Data { get; set; }

    }
}

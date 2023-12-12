using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiraSizde2sayfa94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();
            Console.WriteLine("oda sayısı:" + ev.oda);
            Console.WriteLine("meter kare:"+ev.metrekare);
        }
    }
    class Ev
    {
        public int oda { get; set; }
        public int metrekare { get; set; }
        public Ev() 
        {
          oda = 5;
          metrekare = 8;
        }
    }
}

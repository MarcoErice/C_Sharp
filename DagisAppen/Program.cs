using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagisAppen
{
    class Program
    {
        static void Main(string[] args)
        {
            var klossbräda = new Klossbräda();
            var blyboll = new Blyboll();
            klossbräda.Acceptera(blyboll);
            var boll = new Boll();
            klossbräda.Acceptera(boll);
        }
    }
}

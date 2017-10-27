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
            var rektangel = new Rektangel();
            klossbräda.Accept(rektangel);
            var blyboll = new Blyboll();
            klossbräda.Accept(blyboll);
            var boll = new Boll();
            klossbräda.Accept(boll);
            var kon = new Kon();
            klossbräda.Accept(kon);
        }
    }
}

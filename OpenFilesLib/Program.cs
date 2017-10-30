using Opens2FilesLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFilesLib
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, var god ange sökvägen till första filen");
            var firstFile = Console.ReadLine(); // C:\Users\marco\Desktop\FirstFile.txt
            var amountContent = File.ReadAllText(firstFile);
            Console.WriteLine("Hej, var god ange sökvägen till andra filen");
            var secondFile = Console.ReadLine(); // C:\Users\marco\Desktop\SecondFile.txt
            var qtyContent = File.ReadAllText(secondFile);
            
            var twoFilesProduct = new TwoFilesProduct();
           
            Console.WriteLine($"{twoFilesProduct.Product(amountContent,qtyContent)}\n");
            Console.ReadLine();


        }
    }
}

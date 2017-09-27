// Obejkt Orienterad Programmering.
using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // StudentDemo();
            InheritanceDemo();
        }

        private static void InheritanceDemo()
        {
            Animal anAnimal = new Animal();
            anAnimal.Eat();
            Lion aLion = new Lion();
            aLion.Eat();
        }

        private static void StudentDemo()
        {
            var marco = new Student();
            marco.Name = "Marco Erice";
            marco.Email = "marco_erice@hotmail.com";
            marco.TooTired += Marco_TooTired;
            marco.StudyHarder();
            marco.StudyHarder();
            marco.StudyHarder();
            Console.WriteLine($"Hello World to {marco}");
            Console.ReadLine();
        }

        private static void Marco_TooTired(object sender, EventArgs e)
        {
            Console.WriteLine("Student  need to rest.");
        }
    }
}

using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Volum paralelipiped dreptunghic
            int lungime, latime, inaltime, volum;
            Console.WriteLine("Introduceti lungimea: ");
            lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea: ");
            latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea: ");
            inaltime = int.Parse(Console.ReadLine());
            volum = lungime * latime * inaltime;
            Console.WriteLine("Volumul paralelipipedului este: " + volum);
        }
    }
}

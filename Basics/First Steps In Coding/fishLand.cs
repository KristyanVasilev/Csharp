using System;

namespace fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double Skumriq = double.Parse(Console.ReadLine());
            double Caca = double.Parse(Console.ReadLine());
            //cena skumriq
            double PalamudKg = double.Parse(Console.ReadLine());
            double SafridKg = double.Parse(Console.ReadLine());
            double MidiKg = double.Parse(Console.ReadLine());

            double Palamud = Skumriq + (Skumriq * 0.60);
            double Safrid = Caca + (Caca * 0.80);
            double midi = 7.50;

            double Palamudtotal = Palamud * PalamudKg;
            double Safridtotal = Safrid * SafridKg;
            double miditotal = midi * MidiKg;

            double totalsum = Palamudtotal + Safridtotal + miditotal;

            Console.WriteLine(String.Format("{0:0.00}", totalsum));
        }
    }
}

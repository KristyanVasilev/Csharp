using System;

namespace grandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double litres = 0;
            double degres = 0;

            for (int i = 0; i < days; i++)
            {
                double litresRakia = double.Parse(Console.ReadLine());
                litres += litresRakia;
                double degreesRakia = double.Parse(Console.ReadLine());
                degres += litresRakia * degreesRakia;
            }
            Console.WriteLine($"Liter: {litres:f2}");
            Console.WriteLine($"Degrees: {(degres / litres):f2}");
            if ((degres/litres) < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if ((degres / litres) >= 38 && (degres / litres) <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if ((degres / litres) > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}

using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int daysforcampain = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int NumCakes = int.Parse(Console.ReadLine());
            int NUmGofret = int.Parse(Console.ReadLine());
            int Numpancakes = int.Parse(Console.ReadLine());

            int Cake = 45 * NumCakes;
            double gofret = 5.80 * NUmGofret;
            double pancake = 3.20 * Numpancakes;

            double totalsumfor1day = (Cake + gofret + pancake) * cookers;
            double totalsumforallcampain = totalsumfor1day * daysforcampain;
            double totalsum = totalsumforallcampain - (totalsumforallcampain / 8 );

            Console.WriteLine(totalsum);



        }
    }
}

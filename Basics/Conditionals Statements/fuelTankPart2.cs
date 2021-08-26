using System;

namespace fuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fuelType = Console.ReadLine().ToLower();
            double Litres = double.Parse(Console.ReadLine());
            string clubCart = Console.ReadLine().ToLower();

            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;
            double gasPrice = 0.93;

            if (fuelType == "gasoline" )
            {
                if (Litres >= 20 && Litres <= 25 && clubCart == "yes")
                {
                    double price = Litres * (gasolinePrice - 0.18);
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (Litres > 25 && clubCart == "yes")
                {
                    double price = Litres * (gasolinePrice - 0.18);
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres >= 20 && Litres <= 25)
                {
                    double price = Litres * gasolinePrice;
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres > 25)
                {
                    double price = Litres * gasolinePrice;
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "yes" && Litres < 20)
                {
                    double price = Litres * (gasolinePrice - 0.18);
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (clubCart == "no" && Litres < 20)
                {
                    double price = Litres * gasolinePrice;
                    Console.WriteLine($"{price:f2} lv.");
                }


            }
            else if (fuelType == "diesel")
            {
                if (Litres >= 20 && Litres <= 25 && clubCart == "yes")
                {
                    double price = Litres * (dieselPrice - 0.12);
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (Litres > 25 && clubCart == "yes")
                {
                    double price = Litres * (dieselPrice - 0.12);
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres >= 20 && Litres <= 25)
                {
                    double price = Litres * dieselPrice;
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres > 25)
                {
                    double price = Litres * dieselPrice;
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
            
                else if (clubCart == "yes" && Litres < 20)
                {
                    double price = Litres * (dieselPrice - 0.12);
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (clubCart == "no" && Litres < 20)
                {
                    double price = Litres * dieselPrice;
                    Console.WriteLine($"{price:f2} lv.");
                }

            }
            else if (fuelType == "gas")
            {
                if (Litres >= 20 && Litres <= 25 && clubCart == "yes")
                {
                    double price = Litres * (gasPrice - 0.08);                    
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (Litres > 25 && clubCart == "yes")
                {
                    double price = Litres * (gasPrice - 0.08);
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres >= 20 && Litres <= 25)
                {
                    double price = Litres * gasPrice;
                    double priceAfterCart = price - (price * 0.08);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "no" && Litres > 25)
                {
                    double price = Litres * gasPrice;
                    double priceAfterCart = price - (price * 0.10);
                    Console.WriteLine($"{priceAfterCart:f2} lv.");
                }
                else if (clubCart == "yes" && Litres < 20)
                {
                    double price = Litres * (gasPrice - 0.08);                   
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (clubCart == "no" && Litres < 20)
                {
                    double price = Litres * gasPrice ;
                    Console.WriteLine($"{price:f2} lv.");
                }
               
            }





        }
    }
}

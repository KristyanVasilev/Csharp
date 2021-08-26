using System;

namespace pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	Първи ред – брой дни – цяло число в интервал[1…5000]
            //•	Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodForDogKg = double.Parse(Console.ReadLine());
            double foodForCatKg = double.Parse(Console.ReadLine());
            double foodForTurtleg = double.Parse(Console.ReadLine());

            //Марина обича да пътува. Тя има 3 домашни любимеца(куче, котка и костенурка). 
            //    Когато заминава на пътешествие трябва да съобрази колко храна да им остави,
            //    за да не останат гладни. Напишете програма, която пресмята колко килограма храна ще изядат всички за времето,
            //    в което Марина отсъства и дали оставената храна от нея ще им е достатъчна. 
            //    Всяко животно изяжда определено количество храна на ден.

            double totalFoodDog = foodForDogKg * days;
            double totalFoodCat = foodForCatKg * days;
            double totalfoodturtle = (foodForTurtleg / 1000) * days;
            
            double totalFood = totalFoodDog + totalFoodCat + totalfoodturtle;
            ;

            if (totalFood <= foodLeft)
            {
                double foodResidue = Math.Floor(foodLeft - totalFood);
                Console.WriteLine($"{foodResidue} kilos of food left.");
            }
            else
            {
                double foodNeed = Math.Ceiling(totalFood - foodLeft);
                Console.WriteLine($"{foodNeed} more kilos of food are needed.");
            }



                //            •	Ако оставената храна Е достатъчна:
                //            o   "{килограма остатък} kilos of food left."
                //	Резултатът трябва да е закръглен към по - ниското цяло число
                //•	Ако оставената храна НЕ Е достатъчна:
                //o   “{ килограма недостигат}
                //            more kilos of food are needed.”
                //	Резултатът трябва да е закръглен към по - високото цяло число




        }
    }
}

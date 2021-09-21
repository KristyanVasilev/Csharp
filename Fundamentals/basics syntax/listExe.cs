using System;
using System.Linq;
using System.Collections.Generic;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> shoppingList = new List<string>();

            shoppingList.Add("cucumber");
            shoppingList.Add("tomato");
            shoppingList.Add("carrot");
            shoppingList.Add("peper");
            shoppingList.Add("milk");

            Console.WriteLine(string.Join(" ", shoppingList));
            Console.WriteLine("---------------------------");

            shoppingList.Remove("cucumber"); // маха написаното, но само един път
            shoppingList.RemoveAt(0); // маха 0 индекс

            Console.WriteLine(string.Join(" ", shoppingList));

            shoppingList.Clear(); // 1исти всичко

            ////-----------------------------------------------------------------------------------------------

            List<string> names = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", names));

            ////-------------------------------------------------------------------------

            List<int> points = new List<int>();

            int k = int.Parse(Console.ReadLine());

            for (int j = 0; j < k; j++)
            {
                points.Add(int.Parse(Console.ReadLine()));
            }

            for (int p = 0; p  < k; p ++)
            {
                Console.WriteLine(points[p]);
            }


            Console.WriteLine(string.Join(" ", points));

            ////--------------------------------------------------------------------------
            
            


        }
    }
}

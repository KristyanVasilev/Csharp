using System;
using System.Collections.Generic;
using System.Linq;


namespace _1va
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> waterLvl = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
            Stack<double> flourLvl = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));


            var dict = new Dictionary<string, int>();
            dict.Add("Muffin", 0);
            dict.Add("Baguette", 0);
            dict.Add("Bagel", 0);
            dict.Add("Croissant", 0);

            while (waterLvl.Count > 0 && flourLvl.Count > 0)
            {
                double water = waterLvl.Peek();
                double flour = flourLvl.Peek();
                double sum = water + flour;
                double waterPercent = (water * 100) / sum;
                double flourPercent = (flour * 100) / sum;

                if (waterPercent == 40 && flourPercent == 60)
                {
                    dict["Muffin"]++;
                    waterLvl.Dequeue();
                    flourLvl.Pop();
                }
                else if (waterPercent == 30 && flourPercent == 70)
                {
                    dict["Baguette"]++;
                    waterLvl.Dequeue();
                    flourLvl.Pop();
                }
                else if (waterPercent == 20 && flourPercent == 80)
                {
                    dict["Bagel"]++;
                    waterLvl.Dequeue();
                    flourLvl.Pop();
                }
                else
                {
                    if (flour == water)
                    {
                        dict["Croissant"]++;
                        waterLvl.Dequeue();
                        flourLvl.Pop();
                    }
                    else
                    {
                        double flourToEnqueue = flour - water;
                        dict["Croissant"]++;
                        waterLvl.Dequeue();
                        flourLvl.Pop();
                        flourLvl.Push(flourToEnqueue);
                    }
                }
            }
            var sortedDict = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            foreach (var item in sortedDict)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }       
            }
            if (waterLvl.Count > 0)
            {
                Console.Write("Water left: ");
                Console.WriteLine(string.Join(", ", waterLvl));
            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (flourLvl.Count > 0)
            {
                Console.Write("Flour left: ");
                Console.WriteLine(string.Join(", ", flourLvl));
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
//•	Croissant – consists of 50% water and 50% flour
//•	Muffin – consists of 40% water and 60% flour
//•	Baguette – consists of 30% water and 70% flour
//•	Bagel – consists of 20% water and 80% flour 


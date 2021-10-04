using System;
using System.Linq;

namespace T09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLenght = int.Parse(Console.ReadLine()); // Получаваме дължината на всичките DNА проби
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLenght];
            int dnaSum = 0; // Най - високото DNA 
            int dnaCount = -1; // DNA count. Започват от -1, за да не излезем никога извън масива!!!
            int dnaStartIndex = -1;
            int dnaSamples = 0; // Най - добрата ни проба.
            

            int sample = 0; // Текущи проби DNA.
            while (input != "Clone them!")
            {
                //current dna info
                sample++; // Увеличаваме текущите проби.
                int[] currDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCount = 0; // Текущи проби
                int currStartIndex = 0;
                int currEndIndex = 0;
                bool isCurrDnaBetter = false;
                int currDnaSum = 0;

                int count = 0; //Продължителността
                for (int i = 0; i < currDna.Length; i++)
                {
                    if (currDna[i] != 1) // Щом имаме различно от 0, получаваме дължина.
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }
                //01101
                //0 11 0 1 => 11 (endIndex = 2) =>  (startIndex 2 - 2 = 0 + 1 => 1)
                currStartIndex = currEndIndex - currCount + 1;
                //01101.Sum() =>3
                currDnaSum = currDna.Sum();

                //Check current dna with best dna
                if (currCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }
                if (isCurrDnaBetter)
                {
                    DNA = currDna;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSamples = sample;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ",DNA));

        }
    }
}


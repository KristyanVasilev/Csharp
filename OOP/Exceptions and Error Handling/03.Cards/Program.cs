using System;
using System.Collections.Generic;

namespace _03.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();

            string[] input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    var tokens = input[i].Split();
                    var card = new Card(tokens[0], tokens[1]);
                    cards.Add(card);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var card in cards)
            {
                Console.Write(card.ToString() + " ");
            }
        }
    }
}

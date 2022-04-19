using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public partial class Program
    {
        public class HotDrinkMachine
        {

            private List<Tuple<string, IHotDrinkFactory>> namedFactories =
              new List<Tuple<string, IHotDrinkFactory>>();

            public HotDrinkMachine()
            {

                foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
                {
                    if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                    {
                        namedFactories.Add(Tuple.Create(
                          t.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(t)));
                    }
                }
            }

            public IHotDrink MakeDrink()
            {
                Console.WriteLine("Available drinks");
                for (var index = 0; index < namedFactories.Count; index++)
                {
                    var tuple = namedFactories[index];
                    Console.WriteLine($"{index}: {tuple.Item1}");
                }

                while (true)
                {
                    string s;
                    if ((s = Console.ReadLine()) != null
                        && int.TryParse(s, out int i) // c# 7
                        && i >= 0
                        && i < namedFactories.Count)
                    {
                        Console.Write("Specify amount: ");
                        s = Console.ReadLine();
                        if (s != null
                            && int.TryParse(s, out int amount)
                            && amount > 0)
                        {
                            return namedFactories[i].Item2.Prepare(amount);
                        }
                    }
                    Console.WriteLine("Incorrect input, try again!");
                }
            }
        }
    }
}

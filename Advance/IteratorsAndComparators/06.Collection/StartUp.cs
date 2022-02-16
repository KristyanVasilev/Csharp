using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);
            string commands = Console.ReadLine();

            try
            {
                while (commands != "END")
                {
                    if (commands == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (commands == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (commands == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (commands == "PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                    }
                    commands = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

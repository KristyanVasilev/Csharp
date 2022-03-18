using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);

            foreach (var method in type.GetMethods())
            {
                object[] attrs = method.GetCustomAttributes(false);

                foreach (var attr in attrs)
                {
                    var authorAttr = attr as AuthorAttribute;
                    if (authorAttr != null)
                    {
                        Console.WriteLine($"{method.Name} is written by {authorAttr.Name}");
                    }
                }
            }
        }
    }
}

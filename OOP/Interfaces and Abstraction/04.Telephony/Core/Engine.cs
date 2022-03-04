using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephone
{
    public class Engine
    {
        private Smartphone smartphone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            this.phoneNumbers = Console.ReadLine().Split().ToList();
            this.urls = Console.ReadLine().Split().ToList();

            CallNumber();
            BrowseUrl();
        }

        private void BrowseUrl()
        {
            foreach (var url in this.urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CallNumber()
        {
            foreach (var number in this.phoneNumbers)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

using BuilderFacets;
using System;

namespace BuilderFacets1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Lives.Adress("Moskovska 4")
                      .Postcode("2000")
                      .City("Sofia")
                .Works.CompanyName("Firmata")
                      .Position("CEO")
                      .AnnualIncome(100000);

            Console.WriteLine(person);
        }
    }
}

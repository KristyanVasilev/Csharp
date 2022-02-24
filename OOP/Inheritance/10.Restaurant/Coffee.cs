using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeMillilitres = 50;
        private const decimal CoffePrice =3.50m;
        public Coffee(string name, double caffeine)
            : base(name, CoffePrice, CoffeMillilitres)
        {
            Caffeine = caffeine;
        }
        public double Caffeine { get; set; }
    }
}

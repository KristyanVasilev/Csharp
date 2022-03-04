using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string date)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = date;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; set; }
        public string  Birthdate { get; set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}

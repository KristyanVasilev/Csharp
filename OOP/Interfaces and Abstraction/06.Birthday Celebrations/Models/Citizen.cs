using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable
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
    }
}

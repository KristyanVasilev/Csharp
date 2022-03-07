﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string food)
           : base(name, food)
        {

        }

        public override string ExplainSelf()
        => $"I am {this.Name} and my fovourite food is {this.FavouriteFood} DJAAF";
    }
}

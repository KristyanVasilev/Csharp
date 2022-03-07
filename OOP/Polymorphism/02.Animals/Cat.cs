using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string food)
            : base(name, food)
        {

        }

        public override string ExplainSelf()
        => $"I am {this.Name} and my fovourite food is {this.FavouriteFood} MEEOW";
    }
}

using Easter.Models.Bunnies.Contracts;
using Easter.Models.Dyes.Contracts;
using Easter.Models.Eggs.Contracts;
using Easter.Models.Workshops.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Models.Workshops
{
    class Workshop : IWorkshop
    {
        public Workshop()
        {
        }

        public void Color(IEgg egg, IBunny bunny)
        {
            IDye dye = bunny.Dyes.FirstOrDefault();

            while (dye != null && bunny.Energy > 0 || bunny.Dyes.Count > 0)
            {
                bunny.Work();
                egg.GetColored();
                dye.Use();
                if (egg.IsDone())
                {
                    break;
                }
                if (dye.IsFinished())
                {
                    bunny.Dyes.Remove(dye);
                    dye = bunny.Dyes.FirstOrDefault();
                }
            }          
        }
    }
}

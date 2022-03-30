using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            racers = new List<IRacer>();
        }
        public IReadOnlyCollection<IRacer> Models => racers;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException("Cannot add null in Racer Repository");
            }

            racers.Add(model);
        }

        public IRacer FindBy(string property)
        {
            return racers.FirstOrDefault(x => x.Username == property);
        }

        public bool Remove(IRacer model)
        {
            return racers.Remove(model);
        }
    }
}

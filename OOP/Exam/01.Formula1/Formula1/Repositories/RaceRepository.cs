﻿using Formula1.Models.Contracts;
using Formula1.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Formula1.Repositories
{
    public class RaceRepository : IRepository<IRace>
    {
        private ICollection<IRace> models;

        public RaceRepository()
        {
            this.models = new List<IRace>();
        }
        public IReadOnlyCollection<IRace> Models => models.ToImmutableArray();

        public void Add(IRace model)
        {
            models.Add(model);
        }

        public IRace FindByName(string name)
        {
            return models.FirstOrDefault(x => x.RaceName == name);
        }

        public bool Remove(IRace model)
        {
            return models.Remove(model);
        }
    }
}

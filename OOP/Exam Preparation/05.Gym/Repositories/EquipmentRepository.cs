using Gym.Models.Equipment;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<Equipment>
    {
        private List<Equipment> equipments;
        public EquipmentRepository()
        {
            equipments = new List<Equipment>();
        }
        public IReadOnlyCollection<Equipment> Models => equipments;

        public void Add(Equipment model)
        {
            equipments.Add(model);
        }

        public Equipment FindByType(string type)
        {
            return equipments.FirstOrDefault(x => x.GetType().Name == type);
        }

        public bool Remove(Equipment model)
        {
            return equipments.Remove(model);
        }
    }
}

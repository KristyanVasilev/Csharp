using System;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
		private string name;
		private double baseHealth;
		private double health;
		private double baseArmor;
		private double armor;
		private double abilityPoints;
		private IBag bag;

        protected Character(string name, double health, double armor, double abilityPoints, IBag bag)
        {
            Name = name;
			BaseHealth = health;
			Health = health;
			BaseArmor = armor;
			Armor = armor;
			AbilityPoints = abilityPoints;
            Bag = bag;
        }

        public string Name
        {
            get
            {
				return name;
            }
			private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
				name = value;
			}
        }
	
		public double Health
        {
			get => health;
			internal set
			{
				health = value;
			}
		}

		public double BaseHealth { get; }
		public double Armor
		{
			get => armor;
			private set
			{
				if (value < 0)
				{
					armor = 0;
				}
                else
                {
					armor = value;
                }
			}
		}
		public double BaseArmor { get; }

		public double AbilityPoints
        {
			get => abilityPoints;
			private set
			{
				abilityPoints = value;
			}
		}
		public IBag Bag { get; }

		public bool IsAlive { get; set; } = true;

		public void TakeDamage(double hitPoints)
        {
			EnsureAlive();
            if (hitPoints <= Armor)
            {
					Armor -= hitPoints;
            }
            else
            {
				double HealthToBeReduced = hitPoints - Armor;
				Health -= HealthToBeReduced;
				Armor = 0;
            }
            if (Health <= 0)
            {
				Health = 0;
				IsAlive = false;
		    }
        }

		public void UseItem(Item item)
        {
			this.EnsureAlive();
			item.AffectCharacter(this);
        }

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			string aliveOrDead = "";
            if (IsAlive == true)
            {
				aliveOrDead = "Alive";
			}
            else
            {
				aliveOrDead = "Dead";
			}
			sb.AppendLine($"{Name} - HP: {Health}/{BaseHealth}, AP: {Armor}/{BaseArmor}, Status: {aliveOrDead}");
            return sb.ToString().TrimEnd();
        }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}
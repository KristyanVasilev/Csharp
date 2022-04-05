using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private readonly List<Character> characters;
		private readonly Stack<Item> items;

		public WarController()
		{
			characters = new List<Character>();
			items = new Stack<Item>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];
			
			Character myCharacter = null;

			if (characterType == "Warrior")
			{
				myCharacter = new Warrior(name);
			}
			else if (characterType == "Priest")
			{
				myCharacter = new Priest(name);
			}
			else
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, characterType));
            }
            
			characters.Add(myCharacter);
			string result = string.Format(SuccessMessages.JoinParty, name);
			return result;
		}

		public string AddItemToPool(string[] args)
		{
			string itemName = args[0];

			Item myItem = null;
            if (itemName == "HealthPotion")
            {
				myItem = new HealthPotion();
			}
            else if (itemName == "FirePotion")
            {
				myItem = new FirePotion();
			}
            else
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, itemName));
			}
			items.Push(myItem);
			string result = string.Format(SuccessMessages.AddItemToPool, itemName);
			return result;
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];

			Character myCharacter = characters.FirstOrDefault(x => x.Name == characterName);
            
			if (myCharacter == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }
            if (!items.Any())
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
            }

			Item myItem = items.Pop();
			myCharacter.Bag.AddItem(myItem);
			string result = string.Format(SuccessMessages.PickUpItem, characterName, myItem.GetType().Name);
			return result;
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];

			Character myCharacter = characters.FirstOrDefault(x => x.Name == characterName);
			Item myItem = myCharacter.Bag.GetItem(itemName);
			
			if (myCharacter == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
			}

			myCharacter.UseItem(myItem);
			string result = string.Format(SuccessMessages.UsedItem, characterName, itemName);
			return result;
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();
            foreach (var character in characters.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health))
            {
				sb.AppendLine(character.ToString());
            }
			sb.AppendLine();
			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[1];

			Character attackerCharacter = characters.FirstOrDefault(x => x.Name == attackerName);
			Character receiverCharacter = characters.FirstOrDefault(x => x.Name == receiverName);

			if (attackerCharacter == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, attackerName));
			}
			if (receiverCharacter == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
			}
            if (attackerCharacter.GetType().Name == "Priest")
            {
				throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }

			Warrior myWarrior = attackerCharacter as Warrior;
			myWarrior.Attack(receiverCharacter);
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"{attackerName} attacks {receiverName} for {attackerCharacter.AbilityPoints} hit points! {receiverName} has {receiverCharacter.Health}/{receiverCharacter.BaseHealth} HP and {receiverCharacter.Armor}/{receiverCharacter.BaseArmor} AP left!");
            if (!receiverCharacter.IsAlive)
            {
				sb.AppendLine($"{receiverName} is dead!");
            }

			return sb.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

			Character healerCharacter = characters.FirstOrDefault(x => x.Name == healerName);
			Character healingReceiverCharacter = characters.FirstOrDefault(x => x.Name == healingReceiverName);

			if (healerCharacter == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healerName));
			}
			if (healingReceiverCharacter == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healingReceiverName));
			}
            if (healerCharacter.GetType().Name == "Warrior")
            {
				throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, healerName));
			}

			Priest myPriest = healerCharacter as Priest;
			myPriest.Heal(healingReceiverCharacter);
            if (healingReceiverCharacter.Health > 100)
            {
				healingReceiverCharacter.Health = 100;
            }

			string result = $"{healerName} heals {healingReceiverName} for {healerCharacter.AbilityPoints}! {healingReceiverName} has {healingReceiverCharacter.Health} health now!";
			return result;
		}
	}
}

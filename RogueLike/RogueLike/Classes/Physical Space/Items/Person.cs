using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes.Physical_Space.Items
{
    public class Person : Item
    {
        //Constructor//
        //#############//
        /// <summary>
        /// The health of the person.
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// The maximum health the person can have.
        /// </summary>
        public int MaxHealth { get; private set; }

        /// <summary>
        /// The number of coins the person currently has.
        /// </summary>
        public int NumberOfCoins { get; private set; }

        /// <summary>
        /// The number of keys the person currently has.
        /// </summary>
        public int NumberOfKeys { get; private set; }

        /// <summary>
        /// The living status of the person.
        /// </summary>
        public bool IsAlive { get; private set; } = true;

        /// <summary>
        /// A list of what the person can interact with.
        /// </summary>
        protected override Type[] InteractableTypes { get; set; } = { }; //TODO Create Person Interact and Move Lists

        /// <summary>
        /// A list of what objects can move the person.
        /// </summary>
        protected override Type[] MoveableItems { get; set; } = { };

        /// <summary>
        /// A person that exists in a space.
        /// </summary>
        /// <param name="health">The health of the person.</param>
        /// <param name="numberOfCoins">The number of coins the person currently has.</param>
        /// <param name="numberOfKeys">The number of keys the person currently has.</param>
        /// <param name="maxHealth">The maximum health the person can have.</param>
        public Person(int health = 3, int numberOfCoins = 0, int numberOfKeys = 0, int maxHealth = 0) : base('i')
        {
            if (maxHealth == 0)
            {
                maxHealth = health;
            }
            if (health > maxHealth)
            {
                health = maxHealth;
            }
            Health = health;
            MaxHealth = maxHealth;
            NumberOfCoins = numberOfCoins;
            NumberOfKeys = numberOfKeys;
        }


        //Methods//
        //#########//

        /// <summary>
        /// Determines whether the input item can move the person.
        /// </summary>
        /// <param name="interactingItem">The item that is being determined.</param>
        /// <returns>True if the item can move, false if it can't.</returns>
        public override bool CanBeMovedTo(Type interactingItemType)
        {
            return false;
        }

        /// <summary>
        /// Determines whether the input item can interact with the person, and if so, executes said interaction.
        /// </summary>
        /// <param name="interactingItem">The item attempting to interact with the person.</param>
        /// <returns>Whether or not an interaction occurs.</returns>
        public override bool CanInteractWith(Type interactingItemType)
        {
            if (InteractableTypes.Contains(interactingItemType))
            {
                return true;
            }
            return false;
        }

        //TODO Implement Person.Look(Location whereToLook);
        public bool Look(Location playerLocation, Location whereToLook)
        {
            if (whereToLook.GetItem().CanBeMovedTo(GetType()) && whereToLook.GetFloor().CanBeMovedOnBy(GetType()))
            {
                Move(playerLocation, whereToLook);
                return true;
            }
            if (whereToLook.GetItem().CanInteractWith(GetType()))
            {
                // TODO Interact(whereToLook);
                return true;
            }
            return false;
        }

        public bool Move(Location playerLocation, Location whereToMove)
        {
            return playerLocation.SwapItems(whereToMove);
        }

        //Property Modifiers//
        //####################//

        /// <summary>
        /// Heals the person once.
        /// </summary>
        /// <returns>Whether or not any healing occurs.</returns>
        public bool Heal()
        {
            if(Health + 1 >= MaxHealth)
            {
                return false;
            }
            Health++;
            return true;
        }

        /// <summary>
        /// Heals the person the inputted amount.
        /// </summary>
        /// <param name="amount">The amount to be healed.</param>
        /// <returns>Whether or not any healing occurred.</returns>
        public bool Heal(int amount)
        {
            if(Health == MaxHealth)
            {
                return false;
            }
            Health += amount;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
            return true;
        }

        /// <summary>
        /// Deals damage to the person.
        /// </summary>
        /// <returns>Whether the person is still alive or not.</returns>
        public bool TakeDamage()
        {
            if(Health - 1 <= 0)
            {
                Health = 0;
                Die();
                return false;
            }
            Health--;
            return true;
        }

        /// <summary>
        /// Deals the inputted amount of damage to the person.
        /// </summary>
        /// <param name="amount">The amount of damage to be dealt.</param>
        /// <returns>Whether or not the person is still alive.</returns>
        public bool TakeDamage(int amount)
        {
            if(Health - amount <= 0)
            {
                Die();
                return false;
            }
            Health -= amount;
            return false;
        }

        /// <summary>
        /// Kills the person.
        /// </summary>
        public void Die()
        {
            Health = 0;
            IsAlive = false;
        }

        /// <summary>
        /// Increases the amount of coins on the person by 1.
        /// </summary>
        /// <returns>Whether or not any coins were gained.</returns>
        public bool GainCoins()
        {
            NumberOfCoins++;
            return true;
        }

        /// <summary>
        /// Increases the amount of coins on the person by the input amount.
        /// </summary>
        /// <param name="amount">The amount of coins to add.</param>
        /// <returns>Whether or not any coins were added.</returns>
        public bool GainCoins(int amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            NumberOfCoins += amount;
            return true;
        }

        /// <summary>
        /// Tries to remove a coin from the person.
        /// </summary>
        /// <returns>Whether or not a coin could be removed.</returns>
        public bool UseCoin()
        {
            if(NumberOfCoins <= 0)
            {
                return false;
            }
            NumberOfCoins--;
            return true;
        }

        /// <summary>
        /// Tries to remove the input amount of coins from the person.
        /// </summary>
        /// <param name="amount">The amount of coins to remove.</param>
        /// <returns>Whether or not the coins could be removed.</returns>
        public bool UseCoins(int amount)
        {
            if(amount > NumberOfCoins || amount <= 0)
            {
                return false;
            }
            NumberOfCoins -= amount;
            return true;
        }

        /// <summary>
        /// Gives the person a key.
        /// </summary>
        /// <returns>Whether or not a key could be added.</returns>
        public bool GainKeys()
        {
            NumberOfKeys++;
            return true;
        }

        /// <summary>
        /// Gives the person the input amount of keys.
        /// </summary>
        /// <param name="amount">The amount of keys to add.</param>
        /// <returns>Whether or nota key could be added.</returns>
        public bool GainKeys(int amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            NumberOfKeys += amount;
            return true;
        }

        /// <summary>
        /// Removes a key from the person.
        /// </summary>
        /// <returns>Whether or not a key could be removed.</returns>
        public bool UseKey()
        {
            if (NumberOfKeys <= 0)
            {
                return false;
            }
            NumberOfKeys--;
            return true;
        }
    }
}

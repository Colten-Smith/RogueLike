using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Character : Item
    {
        public int Health { get; private set; }
        public int NumberOfKeys { get; private set; }
        public int Coins { get; private set; }
        public bool IsInvincible { get; private set; }
        public Character(int x, int y, char sprite = 'i', int health = 3, int numberOfKeys = 0, int coins = 0, bool isInvincible = false) 
            : base(x, y, sprite)
        {
            Health = health;
            NumberOfKeys = numberOfKeys;
            Coins = coins;
            IsInvincible = isInvincible;
        }


        //TODO Finish Character Methods

        public void TakeDamage()
        {
            Health--;
        }
        public void Heal()
        {
            Health++;
        }
        public void UseKey()
        {
            NumberOfKeys--;
        }
        public void GetKey()
        {
            NumberOfKeys++;
        }
        public void Move(string direction, Chart chart) { }
        private void MoveBlock(string direction, Chart chart) { }
        public void GetInvincibility() 
        {
            IsInvincible = true;
        }
        public void LoseInvincibility()
        {
            IsInvincible = false;
        }
        public void GetCoin()
        {
            Coins++;
        }
        public void LoseCoin()
        {
            Coins--;
        }
    }
}

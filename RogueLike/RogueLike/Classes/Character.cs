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
        public bool IsAlive { get; private set; }
        public Character(int x, int y, char sprite = 'i', int health = 3, int numberOfKeys = 0, int coins = 0, bool isInvincible = false, bool isAlive = true)
            : base(x, y, sprite)
        {
            Health = health;
            NumberOfKeys = numberOfKeys;
            Coins = coins;
            IsInvincible = isInvincible;
        }


        //TODO Finish Character Methods

        public bool TakeDamage()
        {
            Health--;
            if (Health <= 0)
            {
                Die();
                Health = 0;
                return false;
            }
            return true;
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
        //todo Character Move
        public void Move(char direction, Chart currentWorkingChart)
        {
            int newX = X_Position;
            int newY = Y_Position;
            if (direction == 'W')
            {
                newY--;
            }
            else if (direction == 'A')
            {
                newX--;
            }
            else if (direction == 'S')
            {
                newY++;
            }
            else if (direction == 'D')
            {
                newX++;
            }
            if (currentWorkingChart.IsLocationValid($"{newX}|{newY}"))
            {
                string finalCoordinates = DecideAction(newX, newY, currentWorkingChart);
            }
        }
        private void MoveBlock(char direction, Chart chart) { }
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
        public void Die()
        {
            //todo Character Die
        }
        private string DecideAction(int newX, int newY, Chart currentWorkingChart)
        {
            //TODO Create DecideAction Method
        }
    }
}

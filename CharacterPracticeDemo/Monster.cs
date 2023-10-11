using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPracticeDemo
{
    internal class Monster
    {
        public string Type { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int Defence { get; private set; }

        public Monster(string type, int health, int attackPower, int defence)
        {
            Type = type;
            Health = health;
            AttackPower = attackPower;
            Defence = defence;
        }

        public bool TakeDamage(int damage)
        {
            Health -= damage;
            if(Health < 0)
            {
                Health = 0;
            }
            return Health > 0;
        }
    }
}

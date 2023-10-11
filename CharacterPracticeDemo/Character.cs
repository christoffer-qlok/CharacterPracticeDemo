using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterPracticeDemo
{
    internal class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int Defence { get; private set; }

        public Character(string name, int health, int attackPower, int defence)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defence = defence;
        }

        public bool Fight(Monster monster)
        {
            while(true)
            {
                int damage = (new Random()).Next(1, AttackPower) - monster.Defence;
                if (damage > 0)
                {
                    bool survived = monster.TakeDamage(damage);
                    Console.WriteLine($"{Name} did {damage} damage to {monster.Type}, it has {monster.Health} HP left");
                    if (!survived)
                    {
                        Console.WriteLine($"{monster.Type} died!");
                        return true;
                    }
                } else
                {
                    Console.WriteLine($"{monster.Type} missed!");
                }

                damage = (new Random()).Next(1, monster.AttackPower) - Defence;
                if (damage > 0)
                {
                    Health -= damage;
                    if(Health < 0)
                    {
                        Health = 0;
                    }
                    Console.WriteLine($"{monster.Type} did {damage} damage to {Name}, you have {Health} HP left");
                    bool survived = Health > 0;
                    if (!survived)
                    {
                        Console.WriteLine($"{Name} died!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine($"{Name} missed!");
                }

            }
        }
    }
}

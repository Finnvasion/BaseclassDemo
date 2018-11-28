using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public class LivingCreature
    {
        public string Name;
        public bool IsAlive;
        public int CurrentHP;
        public int Dexterity;
        public int Strength;

        public LivingCreature(string name, bool isAlive, int currentHP, int dexterity, int strength)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            Dexterity = dexterity;
            Strength = strength;
        }
        public LivingCreature() { }





    }
}


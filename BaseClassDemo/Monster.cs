using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public class Monster:LivingCreature
    {
        int RewardGold;
        int RewardXP;

        public Monster(string name, bool isAlive, int currentHP, int dexterity, int strength, int rewardGold, int rewardXP):base (name, isAlive, currentHP, dexterity, strength)
      {
        Name = name;
        IsAlive = isAlive;
        CurrentHP = currentHP;
        Dexterity = dexterity;
        Strength = strength;
        RewardGold = rewardGold;
        RewardXP = rewardXP;

      }
        //Methods
        public void ReportStats()
        {
            Console.WriteLine("Player Name: {0}", Name);
            Console.WriteLine("\tIs Alive:{0}", IsAlive);
            Console.WriteLine("\tHP: {0} \tDEX: {1}", CurrentHP, Dexterity);
            Console.WriteLine("\tStrength: {0}", Strength);
            Console.WriteLine("\tGold given: {0}", "\tExperience given: {1}", RewardGold, RewardXP);
        }
    }
}

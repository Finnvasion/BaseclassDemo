using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public static class GameEngine
    {
        static public int battlecount;
        //Hand2Hand combat: player vs monster
        public static void H2HPlayerBattleMonster(Player player, Monster monster)
        {
            Console.WriteLine("\n\nh2H Player {0} vs Monster {1}", player.Name, monster.Name);
            //dexterity determines who goes first
            if (player.Dexterity >= monster.Dexterity)
            {
                //then the player goes first
                int damage = RollDie(player.Strength);
                DamageMonster(monster, damage);
                if (monster.IsAlive)
                {
                    damage = RollDie(monster.Strength);
                    DamagePlayer(player, damage);
                }//TODO: Monster is dead so the victor can claim their spoils
            }
            else
            {
                //the monster goes first
                int damage = RollDie(monster.Strength);
                //TODO: Checks if monster is dead, if he is then he gives loot
                DamagePlayer(player, damage);
            }
        }

        private static void DamageMonster(Monster monster, int damage)
        {
            Console.WriteLine("***{0} is hit with {1} damage***", monster.Name, damage);
            monster.CurrentHP -= damage;
            if (monster.CurrentHP < 0)
            {
                monster.IsAlive = false;
                monster.CurrentHP = 0;
            }
        }
        private static void DamagePlayer(Player player, int damage)
        {
            Console.WriteLine("***{0} is hit with {1} damage***", player.Name, damage);
            player.CurrentHP -= damage;
            if (player.CurrentHP < 0)
            {
                player.IsAlive = false;
                player.CurrentHP = 0;
            }
        }
        public static int RollDie(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }
    }//class GameEngine
}

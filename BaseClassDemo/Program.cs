using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassDemo
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Player Eion = new Player("Eion", true, 40, 22, 8, true, 3, 41);
            Eion.ReportstatS();
            Monster UmberHulk = new Monster("UmberHulk", true, 36, 11, 9, 10, 15);
            UmberHulk.ReportStats();
            GameEngine.battlecount = 0;
            Console.WriteLine();
            Console.ReadKey();
            while (Eion.IsAlive && UmberHulk.IsAlive)
            {
                GameEngine.H2HPlayerBattleMonster(Eion, UmberHulk);
                UmberHulk.ReportStats();
                Console.WriteLine();
                Eion.ReportstatS();
                GameEngine.battlecount++;
                Console.ReadKey();
            }
            Console.WriteLine("battleCount: {0}", GameEngine.battlecount);
            Console.WriteLine("PRESS ANY KEY TO QUIT");
            Console.ReadKey();

        }

    }
}

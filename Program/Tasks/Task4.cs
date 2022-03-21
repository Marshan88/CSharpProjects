using System;

namespace Program.Tasks
{
    internal class Task4
    {
        public static void Run(string[] args)
        {
            string logo = @"________                 __       _________            .__          
\______ \ _____    ____ |  | __  /   _____/ ____  __ __|  |   ______
 |    |  \\__  \  /    \|  |/ /  \_____  \ /    \|  |  \  |  /  ___/
 |    `   \/ __ \|   |  \    <   /        (   _  )  |  /  |__\___ \ 
/_______  (____  /___|  /__|_ \ /_______  /\____/|____/|____/____  >
        \/     \/     \/     \/         \/                       \/";


            string deaded = @"     )             (                     
  ( /(             )\ )            (     
  )\())       (   (()/(  (     (   )\ )  
 ((_)\  (    ))\   /(_)) )\   ))\ (()/(  
__ ((_) )\  /((_) (_))_ ((_) /((_) ((_)) 
\ \ / /((_)(_))(   |   \ (_)(_))   _| |  
 \ V // _ \| || |  | |) || |/ -_)/ _` |  
  |_| \___/ \_,_|  |___/ |_|\___|\__,_|";

            string ggez = @"  ________  _____________________________
 /  _____/ /  _____/\_   _____/\____    /
/   \  ___/   \  ___ |    __)_   /     / 
\    \_\  \    \_\  \|        \ /     /_ 
 \______  /\______  /_______  //_______ \
        \/        \/        \/         \/";


            GameCharacter hero = new GameCharacter("Hero", 50, 20, 20, 40);
            GameCharacter boss = new GameCharacter("Boss", 125, 0, 30, 10);
            Console.WriteLine();

            Console.WriteLine(logo);
            Console.WriteLine(hero.Name + " : " + hero.Health + "HP | " + boss.Name + " : " + boss.Health + "HP" + "\n");

            while (hero.Health > 0 && boss.Health > 0)
            {
                System.Threading.Thread.Sleep(3500);
                hero.Fight(boss);
                boss.Fight(hero);
            }

            Console.WriteLine("     <<<<< " + hero.Name + " : " + hero.Health + "HP" + " >>>>>");
            Console.WriteLine("     <<<<< " + boss.Name + " : " + boss.Health + "HP" + " >>>>>" + "\n");


            if (hero.Health == 0)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(deaded);
                Console.ReadLine();
            }
            if (boss.Health == 0)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(ggez);
                Console.ReadLine();
            }
        }
    }
}
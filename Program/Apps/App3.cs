using System;

namespace Program.Apps
{
    internal class App3
    {
        public static void Run(string[] args)
        {
            string logo = @"________                 __       _________             __          
\______ \ _____    ____ |  | __  /   _____/ ____  __ __|  |   ______
 |    |  \\__  \  /    \|  |/ /  \_____  \ /    \|  |  \  |  /  ___/
 |    `   \/ __ \|   |  \    <   /        (   _  )  |  /  |__\___ \ 
/_______  (____  /___|  /__|_ \ /_______  /\____/|____/|____/____  >
        \/     \/     \/     \/         \/                       \/";


            string deaded = @"▓██   ██▓ ▒█████   █    ██    ▓█████▄  ██▓▓█████ ▓█████▄ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒██▀ ██▌▓██▒▓█   ▀ ▒██▀ ██▌
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ░██   █▌▒██▒▒███   ░██   █▌
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▄   ▌░██░▒▓█  ▄ ░▓█▄   ▌
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒████▓ ░██░░▒████▒░▒████▓ 
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒▓  ▒ ░▓  ░░ ▒░ ░ ▒▒▓  ▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░ ▒  ▒  ▒ ░ ░ ░  ░ ░ ▒  ▒ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░  ░  ▒ ░   ░    ░ ░  ░ 
 ░ ░         ░ ░     ░           ░     ░     ░  ░   ░    
 ░ ░                           ░                  ░      ";

            string ggez = @"  ________  _____________________________
 /  _____/ /  _____/\_   _____/\____    /
/   \  ___/   \  ___ |    __)_   /     / 
\    \_\  \    \_\  \|        \ /     /_ 
 \______  /\______  /_______  //_______ \
        \/        \/        \/         \/";


            GameCharacter hero = new GameCharacter("Hero", 50, 1, 40, 40);
            GameCharacter boss = new GameCharacter("Boss", 125, 0, 30, 10);
            Console.WriteLine();

            Console.WriteLine(logo);
            Console.WriteLine(hero.Name + " : " + hero.Health + "HP | " + boss.Name + " : " + boss.Health + "HP" + "\n");

            while (hero.Health > 0 && boss.Health > 0)
            {
                hero.Fight(boss);
                System.Threading.Thread.Sleep(2000);
                boss.Fight(hero);
                System.Threading.Thread.Sleep(2000);
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
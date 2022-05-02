using System;

namespace Program.Projects
{
    internal class DankSoulsManager
    {
        public static string Logo()
        {
            const string logo = @"________                 __       _________             __          
\______ \ _____    ____ |  | __  /   _____/ ____  __ __|  |   ______
 |    |  \\__  \  /    \|  |/ /  \_____  \ /    \|  |  \  |  /  ___/
 |    `   \/ __ \|   |  \    <   /        (   _  )  |  /  |__\___ \ 
/_______  (____  /___|  /__|_ \ /_______  /\____/|____/|____/____  >
        \/     \/     \/     \/         \/                       \/";
            Console.WriteLine(logo + "\n");
            return logo;
        }

        public void Run()
        {
            var hero = new DankSoulsCharacters("Hero", 50, 1, 40, 40);
            var boss = new DankSoulsCharacters("Boss", 125, 0, 30, 10);
                //var staminaPotion = new Item("Stamina potion", 40);
                //var healthPotion = new Item("Health potion", 50);
                //var strengthPotion = new Item("Strength potion", 30);
            Logo();
            Console.WriteLine("\n");
            Console.WriteLine(hero.Name + " : " + hero.Health + "HP | " + boss.Name + " : " + boss.Health + "HP" + "\n");

            while (hero.Health > 0 && boss.Health > 0)
            {
                hero.Fight(boss);
                System.Threading.Thread.Sleep(2000);
                boss.Fight(hero);
                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine("<<<<< " + hero.Name + " : " + hero.Health + "HP" + " >>>>>");
            Console.WriteLine("<<<<< " + boss.Name + " : " + boss.Health + "HP" + " >>>>>" + "\n");


            if (hero.Health == 0)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(Dead());
                Console.ReadLine();
            }

            if (boss.Health != 0) return;
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(GoodGameEz());
            Console.ReadLine();
        }

        public static string Dead()
        {
            const string deaded = @"▓██   ██▓ ▒█████   █    ██    ▓█████▄  ██▓▓█████ ▓█████▄ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒██▀ ██▌▓██▒▓█   ▀ ▒██▀ ██▌
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ░██   █▌▒██▒▒███   ░██   █▌
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▄   ▌░██░▒▓█  ▄ ░▓█▄   ▌
  ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒████▓ ░██░░▒████▒░▒████▓ 
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒▓  ▒ ░▓  ░░ ▒░ ░ ▒▒▓  ▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░ ▒  ▒  ▒ ░ ░ ░  ░ ░ ▒  ▒ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░  ░  ▒ ░   ░    ░ ░  ░ 
 ░ ░         ░ ░     ░           ░     ░     ░  ░   ░    
 ░ ░                           ░                  ░      ";
            return deaded;
        }

        public static string GoodGameEz()
        {
            const string ggez = @"  ________  _____________________________
 /  _____/ /  _____/\_   _____/\____    /
/   \  ___/   \  ___ |    __)_   /     / 
\    \_\  \    \_\  \|        \ /     /_ 
 \______  /\______  /_______  //_______ \
        \/        \/        \/         \/";
            return ggez;
        }
    }
}

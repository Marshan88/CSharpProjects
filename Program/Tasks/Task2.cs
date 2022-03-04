using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tasks
{
    internal class Task2
    {
        public static void Run(string[] args)
        {

            Chef chef = new Chef();
            chef.MakeSpecialDish();           //Normal chef can't make pasta (like itlian chef) if you type chef.MakePasta, because of no inheritance

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
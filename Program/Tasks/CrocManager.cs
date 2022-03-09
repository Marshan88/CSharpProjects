using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tasks
{
    internal class CrocManager
    {
        public int CheckUserInput(string command, int points, string character)
        {
            if (command == character)
            {
                points += 1;
            }
            else
            {
                points -= 1;
            }
            return points;
        }
    }
}
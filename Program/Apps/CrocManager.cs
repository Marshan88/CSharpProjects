using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program.Apps
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
        public int CheckUserInputTime(string command, int points, double time, string character)
        {
            if (command == character && time < 1)
            {
                points += 1;
            }
            else
            {
                points -= 1;
            }
            return points;
        }        
        //public int CheckUserInputTime(double time)
        //{
        //        if  (time < 1)
        //        {
        //            return 1;
        //        }
        //        return 0;
        //}
    }
}
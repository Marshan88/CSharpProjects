namespace Program.Apps
{
    internal class CrocManager
    {
        public static int CheckUserInput(string command, int points, string character)
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
        public static int CheckUserInputTime(string command, int points, double time, string character)
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
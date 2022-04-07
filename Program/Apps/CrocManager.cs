using System;
using System.Diagnostics;


namespace Program.Apps
{
    internal class CrocManager
    {
        public static string Logo()
        {
            const string logo =
                @"_________                                .___.__.__             ________                       
\_   ___ \_______  ____   ____  ____   __| _/|__|  |   ____    /  _____/_____    _____   ____  
/    \  \/\_  __ \/    \_/ ___\/    \ / __ | |  |  | _/ __ \  /   \  ___\__  \  /     \_/ __ \ 
\     \____|  | \(   _  )  \__(   _  ) /_/ | |  |  |_\  ___/  \    \_\  \/ __ \|  Y Y  \  ___/ 
 \______  /|__|   \____/ \___  >____/\____ | |__|____/\___  >  \______  (____  /__|_|  /\___  >
        \/                   \/           \/              \/          \/     \/      \/     \/" + "\n";
            return logo;
        }

        private int _points;
        private string _command;
        private char _character;

        public int CheckUserInput()
        {
            if (_command == _character.ToString())
            {
                _points += 1;
            }
            else
            {
                _points -= 1;
            }

            return _points;
        }

        public int CheckUserInputTime()
        {
            if (_command == _character.ToString())
            {
                _points += 1;
            }
            else
            {
                _points -= 1;
            }

            return _points;
        }

        public void Run()
        {
            var random = new Random();
            //var stopWatch = new Stopwatch();
            while (true)
            {
                var randomNumber1 = random.Next(1, 101);
                var randomNumber2 = random.Next(1, 101);
                Console.WriteLine(randomNumber1 + " ? " + randomNumber2);
                //stopWatch.Start();
                _command = Console.ReadLine();
                //var timeTaken = stopWatch.Elapsed.TotalSeconds;
                if (randomNumber1 < randomNumber2)
                {
                    _points = CheckUserInput();
                    _points = CheckUserInputTime();
                }
                //stopWatch.Stop();
                Console.WriteLine("Your points: " + _points + "\n");
            }

        }
    }
}

//public int CheckUserInputTime(double time)
//{
//        if  (time < 1)
//        {
//            return 1;
//        }
//        return 0;
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class HealthyHearts
    {
        static void Main(string[] args)
        {
            //ASKS FOR USER INPUT OF AGE
            int age;

            while (true)
            {
                Console.Write("What is your age?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your age needs to be entered as a whole number please.");
                }
            }
            double maxHeartRate = 220 - age;
            double minTargetRate = maxHeartRate * 0.5;
            double maxTargetRate = maxHeartRate * 0.85;

            Console.WriteLine("Your maximum heart rate should be " + maxHeartRate + " beats per minute");
            Console.WriteLine("Your target HR Zone is " + minTargetRate + " - " + maxTargetRate + " beats per minute");
            Console.ReadLine();
        }
    }
}

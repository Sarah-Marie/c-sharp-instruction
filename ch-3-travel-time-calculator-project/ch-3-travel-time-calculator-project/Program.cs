using System;

namespace ch_3_travel_time_calculator_project {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Travel Time Calculator!");

            string choice = "y";
            while (choice.Contains ("y") || choice.Contains ("Y")) {
                double mph;
                double miles;
                Console.Write("Enter miles: ");
                miles = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                mph = Convert.ToDouble(Console.ReadLine());



                double minutesTraveled = (miles / mph) * 60;
                int timeTraveledHours = (int)(minutesTraveled / 60);
                int remainingMinutes = (int)(minutesTraveled % 60);

                Console.WriteLine("Estimated Travel Time: ");
                Console.WriteLine("====================== ");
                Console.WriteLine("Hours:  "+timeTraveledHours );
                Console.WriteLine("Minutes: "+remainingMinutes);

                Console.Write("Continue?");
                choice = Console.ReadLine();
                Console.WriteLine();









            }







            
            
            
            
            
            Console.WriteLine("Bye!");
        }
    }
}

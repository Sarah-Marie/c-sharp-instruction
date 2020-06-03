using System;

namespace ch4_table_of_powers_project4_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Squares and Cubes Table!");

            String choice = "y";
            while (choice.Contains ("y") || choice.Contains("Y")) {
                Console.Write("Enter an integer:  ");

                int n = int.Parse(Console.ReadLine());

                String table = "";
                String header = "";
                Console.WriteLine("+= Number\tSquared\tCubed\n");
                Console.WriteLine("+= ======\t=======\t=====\n");
                table += header;


                for (int i = 1; i <= n; i++) {
                    //each loop will produce 1 line in our table
                    int squared = i * i;
                    int cubed = i * i * i;
                    
            
                    Console.WriteLine(i + "\t" + squared + "\t" + cubed);
                }

                Console.WriteLine("Table");
                Console.WriteLine();
                Console.Write("Continue?");
                choice = Console.ReadLine();
                Console.WriteLine();

            }









            Console.WriteLine("Bye!");
        }
    }
}

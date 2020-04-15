using System;

namespace Project2_1_StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Student Registration Form");

            Console.WriteLine("Enter First Name:");
            Console.WriteLine("continue?");
            Console.ReadLine();

            Console.Write("Enter Last Name:");

            Console.Write("Enter Birth Year:");

            //business logic
            string fname, lname, byear;

            string fullname = fname + lname;
            string temppwd = fname + byear;

            // display output

            Console.WriteLine("Welcome" + fname + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + temppwd);

            Console.WriteLine("Good Day!");
        }
    }
}

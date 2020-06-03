using System;
using System.Collections.Generic;

namespace ch12_list {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Lists in c#");

            List<string> names = new List<string>();
            names.Add("Trevor");
            names.Add("Dennis");
            names.Add("Jeff");
            names.Add("Eric");

            names.Remove("Dennis");

            foreach(string s in names) {
                Console.WriteLine(s);
            }
            
        }
    }
}

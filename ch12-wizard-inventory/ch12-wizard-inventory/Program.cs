﻿using System;
using System.Collections.Generic;

namespace ch12_wizard_inventory {
    class Program {
        static List<string> items = new List<string>();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Wizard Inventory!\n");
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");

            string command = "";
            while (!command.Contains("exit")) {
                DisplayMenu();
                Console.Write("Command:");
                command = Console.ReadLine();
                switch (command) {
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
                Console.WriteLine();
            }











            Console.WriteLine("Bye!");
        }

        private static string FindItemByNumber() {
            string item = null;
            while (item==null) {
                Console.WriteLine("Item Number:");
                int itemNbr = 0;
                try {
                     itemNbr = int.Parse(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid number.");
                    continue;
                }
                item = items[itemNbr-1];
            }
            
                return item;
        }

        private static void DropItem() {
            //prompt for item to drop
            string item = FindItemByNumber();
            //drop the item
            items.Remove(item);
            Console.WriteLine(item + "removed.\n");
        }

        private static void EditItem() {
            // prompt for item to edit
            string item = FindItemByNumber();
            int idx = items.IndexOf(item);
            Console.Write("Updated name:");
            string updItem = Console.ReadLine();
            //edit the item
            items[idx] = updItem;
            Console.WriteLine();
        }

        private static void GrabItem() {
            Console.WriteLine("Grab/Add an item");
            if (items.Count >=4) {
                Console.WriteLine("Cannot add more items.  Please drop and item first");

            }
            else {
                Console.Write("Item Name:");
                string name = Console.ReadLine();
                items.Add(name);
            }
            Console.WriteLine();
        }

        private static void ShowItems() {
            Console.WriteLine("List of items:");
           for (int i=0; i < items.Count; i++) {
                Console.WriteLine((i+1)+". "+items[i]);
            }
            Console.WriteLine();
        }

        static void DisplayMenu() {
            Console.WriteLine("COMMAND MENU:");
            Console.WriteLine("=============");
            Console.WriteLine("show - show all items");
            Console.WriteLine("grab - grab/add item");
            Console.WriteLine("edit - edit items");
            Console.WriteLine("drop - remove items");
            Console.WriteLine("exit - exit app");
            Console.WriteLine();


        }
    }
}

 using System;
 using System.Collections.Generic;

namespace Tres_Cafe
    {
        class Program
        {
            static void Main()
            {
                Menu menu = new Menu();

                // Order list
                List<string> order = new List<string>();
                int total = 0;

                Console.WriteLine("Welcome to Tres Café!");

                // Display menu
                menu.Display();

                // Order
                while (true)
                {
                    Console.WriteLine("\nEnter item (or type 'order completed' to finish): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "order completed")
                        break;

                    if (menu.ContainsItem(input))
                    {
                        order.Add(input);
                        total += menu.GetPrice(input);
                        Console.WriteLine($"{input} added to the order Current total: {total} PHP ");
                    }
                    else
                    {
                        Console.WriteLine("Item is not available");
                    }
                }

                // Order Summary
                Console.WriteLine("\nOrder Summary:");
                foreach (var item in order)
                {
                    Console.WriteLine($"{item} - {menu.GetPrice(item)}");
                }
                Console.WriteLine($"Total: {total}PHP");
            }
        }
    }

         
    

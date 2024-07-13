using System;
using System.Collections.Generic;

namespace Tres_Cafe
{
    public class Menu
    {
        private Dictionary<string, int> menu;

        public Menu()
        {
            menu = new Dictionary<string, int>()
            {
                
                { "Iced Americano", 58 },
                { "Iced Coffee Latte", 68 },
                { "Hazelnut", 68 },
                { "Salted Caramel", 68 },
                { "Caramel Macchiato", 78 },
                { "Spanish Latte", 78 },
                { "Iced Mocha Latte", 78 },
                { "Chocolate Latte", 68 },
                { "Strawberry Latte", 68 },
                { "Matcha Latte", 68 },
                { "Green Apple Soda", 48 },
                { "Strawberry Soda", 48 },
                { "Lychee Soda", 48 },
                { "Lemon Soda", 48 },
                { "Cheese Stick ", 78 },
                { "French Fries", 58 }
            };
        }

        public void Display()
        {
            Console.WriteLine("MENU:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key} - {item.Value} PHP");
            }
        }

        public bool ContainsItem(string item)
        {
            return menu.ContainsKey(item);
        }

        public int GetPrice(string item)
        {
            if(menu.ContainsKey(item))
            {
                return menu[item];
            }
            return menu[item];
        }
    }
}
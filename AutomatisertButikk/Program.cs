using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatisertButikk
{
    class Program
    {
        // Class to represent an item with its name, weight, and quantity
        class Item
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public int Quantity { get; set; }
        }

        static void Main(string[] args)
        {
            // Vekten på forskjellige dagligvarer enhet oppgitt i kg
            double Hermetisketomater = 0.5;
            double Firepakkpepsi = 4;
            double Storrispakke = 5;
            double Fantastor = 1.5;
            double Lefser = 0.3;
            double Sukker = 1;
            double Hvetemel = 2;

            List<double> list = new List<double>
        {
            Hermetisketomater,
            Firepakkpepsi,
            Storrispakke,
            Fantastor,
            Lefser,
            Sukker,
            Hvetemel
        };

            List<string> varer = new List<string>
        {
            "Hermetisketomater",
            "Firepakkpepsi",
            "Storrispakke",
            "Fantastor",
            "Lefser",
            "Sukker",
            "Hvetemel"
        };

            // Dictionary to store the selected items with their information
            Dictionary<string, Item> selectedItems = new Dictionary<string, Item>();
            bool continueShopping = true;

            while (continueShopping)
            {
                // Take user input for the items with quantity
                Console.WriteLine("Legg til vare i handleliste (seperert ved hjelp av komma, eksempel: Hermetisketomater,Firepakkpepsi,Fantastor,Lefser,Hvetemel,Lefser):");
                string userInput = Console.ReadLine();
                string[] selectedItemsWithQuantity = userInput.Split(',');

                if (userInput.ToLower() == "exit")
                {
                    continueShopping = false;
                    break;
                }

                // Parse the user input and update the dictionary of selected items
                foreach (var selectedItem in selectedItemsWithQuantity)
                {
                    string itemName = selectedItem.Trim();

                    if (varer.Contains(itemName))
                    {
                        // Parse the user input and update the dictionary of selected items
                        if (selectedItems.ContainsKey(itemName))
                        {
                            selectedItems[itemName].Quantity++;
                        }
                        else
                        {
                            selectedItems[itemName] = new Item { Name = itemName, Weight = list[varer.IndexOf(itemName)], Quantity = 1 };
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Feil vare: {itemName}. Legg til en vare fra sortimentet eller 'exit' for å fullføre handelen.");
                    }
                }

                // Print each item in descending order based on weight
                Console.WriteLine();
                Console.WriteLine("Selected items in descending order based on weight:");
                foreach (var itemName in selectedItemsWithQuantity.OrderByDescending(item => list[varer.IndexOf(item.Trim())]))   // her må vi se litt
                {
                    var item = selectedItems[itemName.Trim()];
                    Console.WriteLine($"{item.Name} - Weight: {item.Weight} kg");
                }

                Console.WriteLine();

                // Sort the selected items in descending order based on weight for the summarized quantities
                var sortedSelectedItems = selectedItems.Values.OrderByDescending(item => item.Weight);

                // Print the selected items with weights and summarized quantities
                Console.WriteLine("Selected items with weights and summarized quantities:");
                foreach (var item in sortedSelectedItems)
                {
                    Console.WriteLine($"{item.Name} - Weight: {item.Weight} kg, Quantity: {item.Quantity}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Handelen er fullført. Takk!");
            Console.ReadKey();
        }
    }
}

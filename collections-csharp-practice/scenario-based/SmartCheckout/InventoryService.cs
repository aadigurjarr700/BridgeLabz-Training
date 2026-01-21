using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.smart_checkout
{
        public class InventoryService
        {
            private Dictionary<string, Item> items =
                new Dictionary<string, Item>();

            public void AddItem(Item item)
            {
                items[item.Name] = item;
            }

            public Item GetItem(string name)
            {
                return items.ContainsKey(name) ? items[name] : null;
            }

            public void DisplayInventory()
            {
                Console.WriteLine("\n--- Inventory ---");
                foreach (var item in items.Values)
                    Console.WriteLine(item);
            }
        }
    }



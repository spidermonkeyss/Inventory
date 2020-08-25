using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    static public class Inventory
    {
        static public List<Item> items = new List<Item>();
        static public int idIterator = 0;

        static public void InitTestItems()
        {
            Item item1 = new Item("Test item 1", 1, 1);
            Item item2 = new Item("Test item 2", 2, 2);
            Item item3 = new Item("Test item 3", 3, 3);
            Item item4 = new Item("Test item 3", 4, 4);
        }

        //returns false if item already exists. True if succesful
        static public bool AddItemToInventory(Item item)
        {
            //Check if item already exists first
            foreach(Item i in items)
            {
                if (i.Name == item.Name)
                    return false;
            }
            items.Add(item);
            InvoFileTools.SaveCurrentFile();
            return true;
        }

        public static bool RemoveItemFromInventory(Item item)
        {
            bool result = items.Remove(item);
            InvoFileTools.SaveCurrentFile();
            return result;
        }

        public static decimal GetTotalInventoryValue()
        {
            decimal total = 0;
            foreach(Item item in items)
            {
                total += item.TotalValue;
            }
            return total;
        }

        public static bool LoadInventoryFromFile(string fileName)
        {
            InvoFile invoFile = InvoFileTools.LoadFile(fileName);
            if (invoFile == null)
                return false;
            for (int i = 0; i < invoFile.items.Length; i++)
            {
                Item item = new Item(invoFile.items[i].name, invoFile.items[i].price, invoFile.items[i].quantity);
                items.Add(item);
            }
            return true;
        }

        public static void UnloadInventory()
        {
            items.Clear();
        }

        public static Item GetItemByID(int _id)
        {
            foreach (Item item in items)
            {
                if (item.id == _id)
                    return item;
            }

            return null;
        }
    }
}

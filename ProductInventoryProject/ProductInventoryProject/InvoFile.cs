using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProductInventoryProject
{
    public static class InvoFileTools
    {
        static public string loadedFileName = null;

        public static void SaveCurrentFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            string filePath = Directory.GetCurrentDirectory() + "/" + loadedFileName + ".invo";
            FileStream fs = new FileStream(filePath, FileMode.Create);

            InvoFile invoFile = new InvoFile(Inventory.items);

            bf.Serialize(fs, invoFile);
            fs.Close();
        }

        public static void SaveNewFile(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string filePath = Directory.GetCurrentDirectory() + "/" + fileName + ".invo";
            FileStream fs = new FileStream(filePath, FileMode.Create);

            InvoFile invoFile = new InvoFile(Inventory.items);

            bf.Serialize(fs, invoFile);
            fs.Close();
            loadedFileName = fileName;
        }

        public static InvoFile LoadFile(string fileName)
        {
            string filePath = Directory.GetCurrentDirectory() + "/" + fileName + ".invo";
            if (File.Exists(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(filePath, FileMode.Open);

                InvoFile invoFile = (InvoFile)bf.Deserialize(fs);
                fs.Close();
                loadedFileName = fileName;
                return invoFile;
            }
            else
            {
                Console.WriteLine("Couldn't load file " + fileName);
                return null;
            }
        }
    }

    [Serializable]
    public class InvoFile
    {
        public ItemData[] items;
           
        public InvoFile(List<Item> itemList)
        {
            items = new ItemData[itemList.Count];
            int index = 0;
            foreach(Item item in itemList)
            {
                ItemData itemData = new ItemData();
                itemData.id = item.id;
                itemData.name = item.Name;
                itemData.price = item.Price;
                itemData.quantity = item.Quantity;
                items[index] = itemData;
                index++;
            }
        }
    }

    [Serializable]
    public struct ItemData
    {
        public int id;
        public string name;
        public decimal price;
        public int quantity;
    }
}


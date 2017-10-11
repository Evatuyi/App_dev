using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;

namespace ShoppingMap {
    public class ItemCategory {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public List<Item> items { get; set; }

        public string name { get; set; }

        public ItemCategory() {
            items = new List<Item>();
            this.name = "undefined";
        }

        public ItemCategory(string name) {
            items = new List<Item>();
            this.name = name;
        }

        public ItemCategory(string name, List<Item> items) {
            this.name = name;
            this.items = items;
        }

        public void addItem(Item item) {
            items.Add(item);
        }

        public void removeItemAtIndex(int index) {
            items.RemoveAt(index);
        }

        public override String ToString() {
            String val = "Items: (" + items.Count + ")\n";
            foreach(Item item in items) {
                val += item.ToString();
            }
            return val;
        }
    }
}

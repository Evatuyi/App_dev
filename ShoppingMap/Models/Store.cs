using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShoppingMap.Models {
    public class Store {
        public string name { get; set; }

        public List<ItemCategory> categories { get; set; }

        public string img { get; set; } = "no_image.png";

        public Store(string name) {
            this.categories = new List<ItemCategory>();
            this.name = name;
        }

        public Store(string name, List<ItemCategory> categories) {
            this.name = name;
            this.categories = categories;
        }

        public void addCategory(ItemCategory category) {
            categories.Add(category);
        }
    }
}

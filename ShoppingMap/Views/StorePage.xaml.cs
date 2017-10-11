using System;
using System.Collections.Generic;
using ShoppingMap.Models;
using ShoppingMap.Styling;
using Xamarin.Forms;

namespace ShoppingMap.Views
{
    public partial class StorePage : ContentPage
    {
        public Store store;

        int itemId = 0;
        public ItemCategory items;

        SQLiteDatabase db = App.Database;
#if DEBUG
        public void AddItems() {
            items = new ItemCategory();
            db.SaveItemAsync(new Item("Nike"));
            db.SaveItemAsync(new Item("Blue suede"));
            db.SaveItemAsync(new Item("Red shoe"));
            db.SaveItemAsync(new Item("Brown sweater"));
            db.SaveItemAsync(new Item("Black sweater"));
        }
#endif
        public StorePage() {
            InitializeComponent();

            mainStack.BackgroundColor = Styles.secondaryColor;
            //d b.Clear().ContinueWith(task => AddItems());
            //AddItems();
        }

        public void LoadCategories() {
            foreach (ItemCategory category in store.categories) {
                StoreItemSection section = new StoreItemSection(category.name, category.items);
                headers.Children.Add(section);
                headers.Children.Add(section.content);
            }
            storeMap.Source = store.img;
        }
    }
}

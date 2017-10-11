using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ShoppingMap.Models;
using ShoppingMap.ViewModels;
using Xamarin.Forms;

namespace ShoppingMap.Views {
    public partial class MainPage : ContentPage {
        ObservableCollection<Store> stores = new ObservableCollection<Store>();
        List<Store> allStores = new List<Store>();


        public MainPage() {
            InitializeComponent();

            allStores = DefaultStores.GetStores();
            foreach(Store store in allStores) {
                stores.Add(store);
            }
            Stores.ItemsSource = stores;

            searchBar.TextChanged += (sender, e) => {
                Stores.ItemsSource = SearchModel.Search(searchBar.Text, allStores);
            };
        }



        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e) {
            StorePage storePage = new StorePage();
            Store store = (Store)e.Item;
            storePage.Title = store.name;
            storePage.store = store;
            storePage.LoadCategories();

            Navigation.PushAsync(storePage);
        }
    }
}

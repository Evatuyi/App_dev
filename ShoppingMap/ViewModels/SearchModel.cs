using System;
using System.Collections.Generic;
using ShoppingMap.Models;

namespace ShoppingMap.ViewModels {
    public class SearchModel {
        public static List<Store> Search(string searchValue, List<Store> stores) {
            searchValue = searchValue.ToLower();
            if (searchValue == "") {
                return stores;
            }

            List<Store> newStores = new List<Store>();
            foreach (Store store in stores) {
                foreach (ItemCategory cat in store.categories) {
                    foreach (Item i in cat.items) {
                        if (i.name.ToLower().Contains(searchValue)) {
                            if (!newStores.Contains(store)) {
                                newStores.Add(store);
                            }
                        }
                    }
                }

                if (store.name.ToLower().Contains(searchValue)) {
                    if (!newStores.Contains(store)) {
                        newStores.Add(store);
                    }
                }
            }
            return newStores;
        }
    }
}

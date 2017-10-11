using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net.Interop;

namespace ShoppingMap {
    public class SQLiteDatabase {
        readonly SQLiteAsyncConnection database;

        public SQLiteDatabase(string dbPath) {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetItemsAsync() {
            return database.Table<Item>().ToListAsync();
        }

        public Task<int> Clear() {
            return database.DropTableAsync<Item>();
        }

        public List<Item> GetItemsNotDoneAsync()
        {
            return database.Table<Item>().Where(item => item.name == "Done").ToListAsync().GetAwaiter().GetResult();
        }
        public Task<Item> GetItemAsync(string id) {
            return database.Table<Item>().Where(i => i.name == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Item item) {
            
                return database.InsertAsync(item);
            
        }

        public Task<int> DeleteItemAsync(Item item) {
            return database.DeleteAsync(item);
        }
    }
}

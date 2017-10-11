using ShoppingMap.Views;
using Xamarin.Forms;

namespace ShoppingMap {
    public partial class App : Application {
        static SQLiteDatabase database;

        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static SQLiteDatabase Database {
            get {
                if (database == null) {
                    database = new SQLiteDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TestDB.db3"));
                }
                return database;
            }
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}

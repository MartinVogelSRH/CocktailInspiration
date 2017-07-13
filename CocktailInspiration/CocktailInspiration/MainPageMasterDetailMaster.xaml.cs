using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CocktailInspiration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMasterDetailMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMasterDetailMaster()
        {
            InitializeComponent();

            BindingContext = new MainPageMasterDetailMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainPageMasterDetailMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainPageMasterDetailMenuItem> MenuItems { get; set; }
            
            public MainPageMasterDetailMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainPageMasterDetailMenuItem>(new[]
                {
                    new MainPageMasterDetailMenuItem { Id = 0, Title="Cocktail Inspiration", TargetType = typeof(CocktailInspirationPage) },
                    new MainPageMasterDetailMenuItem { Id = 1, Title="Ingredients", TargetType = typeof(IngridientsPage) },
                    new MainPageMasterDetailMenuItem { Id = 2, Title="Favorite Cocktails", TargetType = typeof(FavoritesPage) },
                    new MainPageMasterDetailMenuItem { Id = 3, Title="Account", TargetType = typeof(AccountPage) },
                    new MainPageMasterDetailMenuItem { Id = 4, Title="Technical", TargetType = typeof(TechnicalPage) },

                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
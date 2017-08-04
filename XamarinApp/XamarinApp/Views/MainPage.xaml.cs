using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.ViewModels;

namespace XamarinApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            ((MainPageViewModel)this.BindingContext).ItemSelectedCommand.Execute((Dino)args.Item);
        }
    }
}

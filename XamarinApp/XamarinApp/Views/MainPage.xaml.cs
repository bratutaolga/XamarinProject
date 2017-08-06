using XamarinApp.Business;
using XamarinApp.ViewModels;
using Xamarin.Forms;

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
            ((MainPageViewModel)this.BindingContext).DinoSelectedCommand.Execute((Dino)args.Item);            
        }
    }
}
using XamarinApp.Business;
using Prism.Navigation;

namespace XamarinApp.ViewModels
{
    public class DetailsPageViewModel : ViewModelBase, INavigationAware
    {
        private Dino _dino;
        public Dino Dino
        {
            get { return _dino; }
            set { SetProperty(ref _dino, value); }
        }

        public DetailsPageViewModel()
        {

        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("dino"))
                Dino = (Dino)parameters["dino"];
        }
    }
}
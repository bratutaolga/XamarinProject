using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Model;

namespace XamarinApp.ViewModels
{
    public class DetailsPageViewModel: ViewModelBase, INavigationAware
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

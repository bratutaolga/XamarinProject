using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Model;
using XamarinApp.Service;

namespace XamarinApp.ViewModels
{
    public class MainPageViewModel: ViewModelBase
    {
        readonly INavigationService _navService;
        IService<Dino> _dinoService;

        DelegateCommand<Dino> _itemSelectedCommand;
        public DelegateCommand<Dino> ItemSelectedCommand => 
            _itemSelectedCommand != null ? _itemSelectedCommand : (_itemSelectedCommand = new DelegateCommand<Dino>(ItemSelected));

        private ObservableCollection<Dino> _mainList;
        public ObservableCollection<Dino> MainList
        {
            get { return _mainList; }
            set { SetProperty(ref _mainList, value); }
        }

        public MainPageViewModel(INavigationService navigationService, IService<Dino> dinoService)
        {
            _navService = navigationService;
            _dinoService = dinoService;
        }

        private async void ItemSelected(Dino item)
        {
            var param = new NavigationParameters();
            param.Add("dino", item);

            await _navService.NavigateAsync("DetailsPage", param);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (MainList == null)
                MainList = new ObservableCollection<Dino>(await _dinoService.GetAll());
        }
    }
}

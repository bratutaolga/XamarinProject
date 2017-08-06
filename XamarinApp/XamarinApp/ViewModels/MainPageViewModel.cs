using XamarinApp.Business;
using XamarinApp.Services;
using Prism.Commands;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace XamarinApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        readonly INavigationService _navigationService;
        IService<Dino> _dinoService;

        DelegateCommand<Dino> _dinoSelectedCommand;
        public DelegateCommand<Dino> DinoSelectedCommand => _dinoSelectedCommand != null ? _dinoSelectedCommand : (_dinoSelectedCommand = new DelegateCommand<Dino>(DinoSelected));

        private ObservableCollection<Dino> _dinoList;
        public ObservableCollection<Dino> DinoList
        {
            get { return _dinoList; }
            set { SetProperty(ref _dinoList, value); }
        }

        public MainPageViewModel(INavigationService navigationService, IService<Dino> dinoService)
        {
            _navigationService = navigationService;
            _dinoService = dinoService;
        }

        private async void DinoSelected(Dino item)
        {
            var p = new NavigationParameters();
            p.Add("dino", item);

            await _navigationService.NavigateAsync("DetailsPage", p);
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (DinoList == null)
                DinoList = new ObservableCollection<Dino>(await _dinoService.GetAll());
        }
    }
}
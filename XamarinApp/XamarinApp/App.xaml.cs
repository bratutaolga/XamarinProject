using Microsoft.Practices.Unity;
using Prism.Unity;
using Xamarin.Forms;
using XamarinApp.Views;
using XamarinApp.Business;
using XamarinApp.Services;

namespace XamarinApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<IService<Dino>, DinoService>(new ContainerControlledLifetimeManager());

            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<DetailsPage>();
        }
    }
}

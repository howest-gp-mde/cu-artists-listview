using System;
using Xamarin.Forms;
using FreshMvvm;
using Xamarin.Forms.Xaml;
using Mde.Artists.Mobile.ViewModels;
using Mde.Artists.Mobile.Domain.Interfaces;
using Mde.Artists.Mobile.Infrastructure.Mocked;

namespace Mde.Artists.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            FreshIOC.Container.Register<IArtistsService, ArtistsService>().AsMultiInstance();

            var artistsPage = FreshPageModelResolver.ResolvePageModel<ArtistsViewModel>();
            MainPage = new FreshNavigationContainer(artistsPage);
                

            InitializeComponent();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

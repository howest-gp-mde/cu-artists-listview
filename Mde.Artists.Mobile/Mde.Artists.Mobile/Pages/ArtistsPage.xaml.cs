using Mde.Artists.Mobile.Domain.Entities;
using Mde.Artists.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.Artists.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtistsPage : ContentPage
    {
        public ArtistsPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewModel = (ArtistsViewModel) BindingContext;
            var tappedArtist = (Artist)e.Item;

            //pass control to the View Model (and give it the Id)
            viewModel.ViewArtistDetailCommand.Execute(tappedArtist.Id);
        }
    }
}
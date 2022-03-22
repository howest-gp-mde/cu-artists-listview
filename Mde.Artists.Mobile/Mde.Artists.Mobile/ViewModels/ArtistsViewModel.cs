using FreshMvvm;
using Mde.Artists.Mobile.Domain.Entities;
using Mde.Artists.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mde.Artists.Mobile.ViewModels
{
    public class ArtistsViewModel : FreshBasePageModel
    {
        protected readonly IArtistsService _artistsService;

        public ArtistsViewModel(IArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        ////er wordt NAAR de pagina genavigeerd (via Push)
        //public override void Init(object initData)
        //{
        //}

        ////er wordt TERUGGEKEERD naar de pagina (via Pop)
        //public override void ReverseInit(object returnedData)
        //{
        //}

        //view wordt getoond (ALTIJD)       
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            var artists = _artistsService.GetArtists();
            Artists = new ObservableCollection<Artist>(artists);
        }


        private ObservableCollection<Artist> artists;

        public ObservableCollection<Artist> Artists
        {
            get { return artists; }
            set {
                artists = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ViewArtistDetailCommand => new Command<Guid>(
            (artistId) =>
            {
                //Navigeer naar de ArtistDetail page en geef het Guid mee!!
                CoreMethods.PushPageModel<ArtistDetailViewModel>(artistId);
            });

    }
}

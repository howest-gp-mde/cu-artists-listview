using FreshMvvm;
using Mde.Artists.Mobile.Domain.Entities;
using Mde.Artists.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Mde.Artists.Mobile.ViewModels
{
    public class ArtistDetailViewModel : FreshBasePageModel
    {
        protected readonly IArtistsService _artistsService;

        public ArtistDetailViewModel(IArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        public override void Init(object initData)
        {
            if(initData is Guid)
            {
                Guid artistId = (Guid)initData;
                var artist = _artistsService.GetArtistById(artistId);

                ArtistName = artist.Name;
                ArtistImage = artist.ImageUrl;
                Songs = new ObservableCollection<Song>(artist.Songs);
            }
            else
            {
                throw new ArgumentException("Init data must be of type Guid", nameof(initData));
            }
        }


        private string artistName;
        public string ArtistName
        {
            get { return artistName; }
            set { 
                artistName = value;
                RaisePropertyChanged();
            }
        }

        private string artistImage;
        public string ArtistImage
        {
            get { return artistImage; }
            set
            {
                artistImage = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<Song> songs;
        public ObservableCollection<Song> Songs
        {
            get { return songs; }
            set
            {
                songs = value;
                RaisePropertyChanged();
            }
        }
    }
}

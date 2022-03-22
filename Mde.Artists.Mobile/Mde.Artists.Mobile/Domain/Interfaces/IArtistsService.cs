using Mde.Artists.Mobile.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Mde.Artists.Mobile.Domain.Interfaces
{
    public interface IArtistsService
    {
        IEnumerable<Artist> GetArtists();

        Artist GetArtistById(Guid id);
    }
}

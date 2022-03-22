using Mde.Artists.Mobile.Domain.Entities;
using Mde.Artists.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mde.Artists.Mobile.Infrastructure.Mocked
{
    public class ArtistsService : IArtistsService
    {
        private static IEnumerable<Artist> artistsBackStore = new List<Artist>
            {
                new Artist
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Isabelle A.",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRomu109iKpTuYa9Il-u-FFJn88kP4F9X0zYwMavaM8Zy5vaQKTjaaKVn-kXzYjBJA5nHI&usqp=CAU",
                    Songs = new List<Song>
                    {
                        new Song {
                            Id = Guid.Parse("00000000-0000-0000-1111-000000000001"),
                            Title = "Lekker Beest"
                        }
                    }
                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Eddy Wally",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQL5kC_IeP_zaZ14psTRCwmDBpWn2SNxP_4gg&usqp=CAU",
                    Songs = new List<Song>
                    {
                        new Song {
                            Id = Guid.Parse("00000000-0000-0000-1111-000000000002"),
                            Title = "Ik spring uit een vliegmachien"
                        },
                        new Song {
                            Id = Guid.Parse("00000000-0000-0000-1111-000000000003"),
                            Title = "Chérie"
                        }
                    }

                },
                new Artist
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Bart Kaëll",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrj1Ogqk4ScBYiskKyDfB2Vm48HyB6WZwadw&usqp=CAU",
                    Songs = new List<Song>
                    {
                        new Song {
                            Id = Guid.Parse("00000000-0000-0000-1111-000000000004"),
                            Title = "Zeil je voor het eerst"
                        },
                        new Song {
                            Id = Guid.Parse("00000000-0000-0000-1111-000000000005"),
                            Title = "Marie-Louise"
                        }
                    }
                }
            };

        public IEnumerable<Artist> GetArtists()
        {
            return artistsBackStore;
        }

        public Artist GetArtistById(Guid id)
        {
            return artistsBackStore.FirstOrDefault(a => a.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Artists.Mobile.Domain.Entities
{
    public class Artist
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}

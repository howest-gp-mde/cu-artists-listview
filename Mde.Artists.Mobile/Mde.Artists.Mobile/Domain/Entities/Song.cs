using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.Artists.Mobile.Domain.Entities
{
    public class Song
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string SampleUrl { get; set; }
    }
}

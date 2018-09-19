using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public Album Album { get; set; }

        public string Contents { get; set; }

        public string ReviewerEmail { get; set; }
    }
   
}
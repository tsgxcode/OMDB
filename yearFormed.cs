using System;
using System.Collections.Generic;
using System.Text;

namespace OMDB
{

    public class Rootobject
    {
        public yearFormd[] Property1 { get; set; }
    }

    public class yearFormd
    {
        public string ArtistName { get; set; }
        public int YearFormed { get; set; }
        public string FavoriteAlbum { get; set; }
        public int YearOfRelease { get; set; }
        public int NumberOfSongs { get; set; }
        public string Genre { get; set; }
        public string FIELD7 { get; set; }
    }

}
}

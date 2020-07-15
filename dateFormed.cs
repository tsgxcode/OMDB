using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OMDB
{


    public class Rootobject
    {
        public dateFormed[] Formed { get; set; }
    }

    public class dateFormed
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


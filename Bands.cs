using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OMDB
{


    public class Rootobject
    {
        public Band[] Bands { get; set; }
    }

    public class Band
    {
        [JsonProperty(PropertyName = " ArtistName")]
        public string ArtistName { get; set; }
        [JsonProperty(PropertyName = " YearFormed")]
        public int YearFormed { get; set; }
        [JsonProperty(PropertyName = " FavoriteAlbum")]
        public string FavoriteAlbum { get; set; }
        [JsonProperty(PropertyName = " YearOfRelease")]
        public int YearOfRelease { get; set; }
        [JsonProperty(PropertyName = " NumberOfSongs")]
        public int NumberOfSongs { get; set; }
        [JsonProperty(PropertyName = " Genre")]
        public string Genre { get; set; }
        public string FIELD7 { get; set; }
    }

}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;

namespace OMDB
{


    public class Festivals
    {
        [JsonProperty(PropertyName = " Artist")]
        public string Artist { get; set; }
        [JsonProperty(PropertyName = " MusicFestival")]
        public string MusicFestival { get; set; }
        [JsonProperty(PropertyName = " Date")]
        public int Date { get; set; }
        [JsonProperty(PropertyName = " Attendees")]
        public int Attendees { get; set; }
        [JsonProperty(PropertyName = " City")]
        public string City { get; set; }
        [JsonProperty(PropertyName = " State")]
        public string State { get; set; }

      
        //public string FIELD7 { get; set; 
    }



}

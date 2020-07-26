
using Newtonsoft.Json;

namespace OMDB
{
    public class RootObject
    {
        RootObject1 rootObject1 = JsonConvert.DeserializeObject<RootObject1>(System.IO.File.ReadAllText("MusicFestivals.json"));
        public OMLFestivals[] festivals { get; set; }
    }



}
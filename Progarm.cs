using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using OMDB;
using System.Text.Json.Serialization;


namespace OMDBmain
{
    internal class Program
    {
        public static string genre { get; set; }
        public static string numberOfSongs { get; set; }
        public static string yearOfRelease { get; set; }
        public static string favoriteAlbum { get; set; }
        public static string formationDate { get; set; }
        public static string artist { get; set; }
        public static string festival { get; set; }



        /*The obsucre Music Database!
A database of strange and wonderful music from around the world.
Concept, design and code by T.Scott George - (C) 2020
V.1.0 */
        public static void Main()

        {
            // About
            string appName = "Obsure Music Library, Welcome! What would you like to add?";
            string appVersion = "1.0";
            string appAuthor = " (C) 2020 T. Scott George";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();



            // User input: Add new Artist and details
            Console.WriteLine("OML! What would you like to add?  ");

            Console.Write("Artist: ");
            artist = Console.ReadLine();
            Console.Write("Year Formed: ");
            formationDate = Console.ReadLine();
            Console.Write("Favorite Album: ");
            favoriteAlbum = Console.ReadLine();
            Console.Write("Year Of Release: ");
            yearOfRelease = Console.ReadLine();
            Console.Write("Number Of Songs: ");
            numberOfSongs = Console.ReadLine();
            Console.Write("Genre: ");
            genre = Console.ReadLine();

            string fullText = (artist + "," + formationDate + "," + favoriteAlbum + "," + yearOfRelease + "," + yearOfRelease + "," + numberOfSongs + "," + genre + ",");

            File.AppendAllText(@"C:\Users\TSG\source\repos\OMDB\Data.txt", fullText + Environment.NewLine);

            // Reads from csv, txt, etc. and displays the current database info
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "OMDB.csv");
            var fileContents = ReadFIle(fileName);
            fileName = Path.Combine(directory.FullName, "OMLFestivasls.json");
            string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in fileLines)
            {
                Console.WriteLine(line);
            }
        }


        public static string ReadFIle(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static List<string[]> festivalsInfo(string fileName)
        {
            var festivalsInfo = new List<string[]>();

            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    festivalsInfo.Add(values);

                }
            }
            return festivalsInfo;
        }


        public static List<OMLFestivals> DeserializeFestivals(string fileName)
        {
            var festivals = new List<OMLFestivals>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                festivals = serializer.Deserialize<List<OMLFestivals>>(jsonReader);
            }
            return festivals;
        }

        public static void SerializeFestivalsToFile(List<OMLFestivals> festivals, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                RootObject1 rootObject1 = JsonConvert.DeserializeObject<RootObject1>(System.IO.File.ReadAllText("OLMFestivals.json"));
                serializer.Serialize(jsonWriter, festivals);
            }
        }
    }
}
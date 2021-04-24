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
    class Program
    {
        public static string genre { get; set; }
        public static string numberOfSongs { get; set; }
        public static string yearOfRelease { get; set; }
        public static string favoriteAlbum { get; set; }
        public static string formationDate { get; set; }
        public static string artist { get; set; }
        

        /*The obsucre Music Database!
          A database of strange and wonderful music from around the world.
          Concept, design and code by T.Scott George - (C) 2020
          V.1.0 */
        public static void Main(string[] args)

        {
            // Some Details
            string appName = "Obsure Music Library, Welcome! What would you like to add?";
            string appVersion = "1.0";
            string appAuthor = " (C) 2020 T. Scott George";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();


            //Master loop
            do
            {
                Console.WriteLine("OML! What would you like to add? ");


                LogNewArtist();
                Console.WriteLine("Would you like to see All artist's albums? ");
                if (Console.ReadLine().ToUpper() == "YES")
                {
                    OutPutLog();
                }
                Console.WriteLine("Add Another? ");

                removeArtist();
               
                if (Console.ReadLine().ToUpper() == "YES")
                {
                    OutPutLog();
                }
                Console.WriteLine("Add Another? ");
            }
            while (Console.ReadLine().ToUpper() == "YES");

        }
        //User adds artist's info to the database
        public static void LogNewArtist()
        {
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

            //Writing to a .txt file
            File.AppendAllText(@"C:\Users\TSG\source\repos\OMDB\Data.txt", $"{"Artist: " + artist}. {"Formation Date: " + formationDate}. {"Favorite Album: " + favoriteAlbum}. {"Year Of Release: " + yearOfRelease}. {"Number Of Songs: " + numberOfSongs}. {"Genre: " + genre}" + Environment.NewLine);
        }

        public static void OutPutLog()
        {
            // Reads from csv, txt, etc. and displays the current database info
            string currentDirectory = Directory.GetCurrentDirectory();
            var directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Data.txt");
            var fileContents = ReadFile(fileName);
            string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in fileLines)
            {
                Console.WriteLine(line);
            }
        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
        //Feature to be added: removing an artist from the database 
        public static void removeArtist()
         {
             Console.Write("Please enter the artist name you want to delete: ");
             string name = Console.ReadLine();
             List<string> lst = File.ReadAllLines("Data.txt").Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
             lst.RemoveAll(x => x.Split('.')[0].Equals(name));
             File.WriteAllLines("Data.txt", lst);
         }

      
    }
} 
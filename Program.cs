using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OMDBmain
{
    internal class Program
    {
        public static object formationDate { get; private set; }
        public static object band { get; private set; }


        /*The obsucre Music Database!
A database of strange and wonderful music from around the world.
Concept, design and code by T.Scott George - (C) 2020
V.1.0 */
        public static void Main()


        {
            // About
            string appName = "The Obsucre Music Database";
            string appVersion = "1.0";
            string appAuthor = " (C) 2020 T. Scott George";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();



            // User input: Add new Artist and details
            
            
                Console.WriteLine("OMDB! What would you like to add?  ");
                Console.Write("Artist: ");
                string band = Console.ReadLine();
                Console.Write("Year Formed: ");
                string formationDate = Console.ReadLine();
                Console.Write("Favorite Album: ");
                string favoriteAlbum = Console.ReadLine();
                Console.Write("Year Of Release: ");
                string yearOfRelease = Console.ReadLine();
                Console.Write("Number Of Songs: ");
                string numberOfSongs = Console.ReadLine();
                Console.Write("Genre: ");
                string genre = Console.ReadLine();
                Console.Write(band + "\n" + formationDate + "\n" + favoriteAlbum + "\n" + yearOfRelease + "\n" + numberOfSongs + "\n" + genre + "\n");

            // Reads from csv, txt, etc. and displays the current database info
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var fileName = Path.Combine(directory.FullName, "OMDB.csv");
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);

            string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var line in fileLines)
            {
                
                Console.WriteLine(line);
                Console.ResetColor();

            }
        }

        public static string WriteFile(string fileName, string band, string formationDate, string favoriteAlbum, string yearOfRelease, string numberOfSongs, string genre)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                return ($"{band} {formationDate} {favoriteAlbum} {yearOfRelease} {numberOfSongs} {genre}");

            }
        }

        private static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                
                return reader.ReadToEnd();


            }

        }

        
    }
}
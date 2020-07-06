using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace OMDBmain
{
    internal class Program
    {
 

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



            // User inputs Artist and certain details
            
            
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


            //Saving additions to file


            // Reads from csv, txt, etc. and displays the current database info
            string currenDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currenDirectory);
            var fileName = Path.Combine(directory.FullName, "OMDB.csv");
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);
        

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
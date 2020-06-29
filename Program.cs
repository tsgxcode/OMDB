using System;
using System.IO;

namespace OMDBmain
{
    internal class Program
    {


        public static string OMDB { get; set; }


        /*The obsucre Music Database!
A database of strange and wonderful music from around the world.
Concept, design and code by T.Scott George - (C) 2020
V.1.0 */
        public static void Main()


        {
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
            // Saving additions to file
            System.Threading.Tasks.Task task = File.AppendAllTextAsync(@"C:\Users\TSG\source\repos\OMDB\Data.txt", OMDB);
            _ = task;


        }


    }
}
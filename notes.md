```c#
using System;
using System.Collections.Generic;

namespace iteration_review
{
    class Program
    {
        static void Main(string[] args)
        {



            //Define a list of dictionaries.
            // Each dictionary will have a key of type string, and a value of type string.
            // Assign the list to a goodSongs variable.
            List<Dictionary<string, string>> goodSongs = new List<Dictionary<string, string>>();

            // Define a HashSet, named allSongs, that contains 7 dictionaries.
            // Each dictionary in the set will have a key of type string, and a value of type string.
            // The key will be the name of an artist.
            // The value will be the name of a song by that artist. Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.


            HashSet<Dictionary<string, string>> allSongs = new HashSet<Dictionary<string, string>>(){
                new Dictionary<string, string>(){
                    {"Band", "Nickleback"},
                    {"Song", "Nickleback's first song"}
                },
                 new Dictionary<string, string>(){
                    {"Band", "Not Nickleback"},
                    {"Song", "Some other song"}
                },
                  new Dictionary<string, string>(){
                    {"Band", "Not Nickleback"},
                    {"Song", "Some other song #2"}
                },
                  new Dictionary<string, string>(){
                    {"Band", "Nickleback"},
                    {"Song", "Nickleback's second song"}
                },
                  new Dictionary<string, string>(){
                    {"Band", "Not Nickleback"},
                    {"Song", "Some other song #3"}
                },
                  new Dictionary<string, string>(){
                    {"Band", "Nickleback"},
                    {"Song", "Nickleback's third song"}
                },
                  new Dictionary<string, string>(){
                    {"Band", "Not Nickleback"},
                    {"Song", "Some other song #4"}
                }
            };


            // Once the set is populated with 7 dictionaries, iterate over the set of songs, and check if the band name is "Nickelback".

            foreach (var song in allSongs)
            {
                if (song["Band"] != "Nickleback")
                {
                    goodSongs.Add(song);
                }
            }


            // If the band is not Nickelback, then add it to the goodSongs list.
            // Uee another foreach loop to print out all the good songs.
            goodSongs.ForEach(s => Console.WriteLine($"Band: {s["Band"]} || Song: {s["Song"]}"));



        }
    }
}

```
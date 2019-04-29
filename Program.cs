using System;
using System.Collections.Generic;

namespace iteration_review
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ Nickleback -------------//
            //Define a list of dictionaries.
            // Each dictionary will have a key of type string, and a value of type string.
            // Assign the list to a goodSongs variable.

            List<Dictionary<string, string>> goodSongs = new List<Dictionary<string, string>>();

            // Define a HashSet, named allSongs, that contains 7 dictionaries.
            // Each dictionary in the set will have a key of type string, and a value of type string.
            List<Dictionary<string, string>> allSongs = new List<Dictionary<string, string>>(){
                new Dictionary<string, string>(){
                    {"Nickelback", "Rockstar"}
                },
                new Dictionary<string, string>(){
                    {"Nickelback", "How you remind me"}
                },
                new Dictionary<string, string>(){
                    {"Nickelback", "Far away"}
                },
                new Dictionary<string, string>(){
                    {"Aerosmith", "Crying"}
                },
                new Dictionary<string, string>(){
                    {"Johnny Cash", "Ring of Fire"}
                }
            };

            Dictionary<string, string> fire = new Dictionary<string, string>(){
                {"Billy Joel", "We didn't start the fire"}
            };

            allSongs.Add(fire);

            // Once the set is populated with 7 dictionaries, iterate over the set of songs, and check if the band name is "Nickelback"
            // If the band is not Nickelback, then add it to the goodSongs list.

            foreach (Dictionary<string, string> songDictionary in allSongs)
            {
                foreach (KeyValuePair<string, string> songKeyValuePair in songDictionary)
                {
                    if (songKeyValuePair.Key != "Nickelback")
                    {
                        goodSongs.Add(songDictionary);
                    }
                }
            }

            foreach (Dictionary<string, string> songDictionary in goodSongs)
            {
                foreach (KeyValuePair<string, string> songKeyValuePair in songDictionary)
                {
                    Console.WriteLine($"{songKeyValuePair.Value} by {songKeyValuePair.Key} is a good song!");
                }
            }


            // Uee another foreach loop to print out all the good songs.

            // ------ COMPANIES AND EMPLOYEES ---//

            // Create an instance of a company. Name it whatever you like.

            Company amazon = new Company("Amazon", DateTime.Now);

            Employee Joey = new Employee()
            {
                Title = "CEO",
                StartDate = DateTime.Now
            };
            Joey.FirstName = "Joey";
            Joey.LastName = "Wellman";

            Employee Nick = new Employee()
            {
                FirstName = "Nick",
                LastName = "Mitchell",
                Title = "Dungeon Master",
                StartDate = DateTime.Now
            };

            Employee Josh = new Employee()
            {
                FirstName = "Josh",
                LastName = "Havey",
                Title = "Assistant to the Dungeon Master",
                StartDate = DateTime.Now
            };

            amazon.HireEmployee(Josh);
            amazon.HireEmployee(Joey);
            amazon.HireEmployee(Nick);

            amazon.ListEmployees();

          


            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */


        }
    }
}

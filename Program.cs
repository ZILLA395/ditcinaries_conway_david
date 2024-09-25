using System;
using System.Collections.Generic;
using System.Collections;

namespace ditcinaries_conway_david
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int, string > topGames = new Dictionary<int, string>();
            topGames.Add(1, "elden ring");
            topGames.Add(2, "dark souls 3");
            topGames.Add(3, "ARK");
            topGames.Add(4, "bloodborn");
            topGames.Add(5, "Raid");
            topGames.Add(6, "monster hunter world");
            topGames.Add(7, "runescape");
            topGames.Add(8, "halo reach");
            topGames.Add(9, "minecraft");
            topGames.Add(10, "bannana boat");

            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console .WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))
            {
                Console .WriteLine($"My favorite game is: {topGames[1]}!");
            }

            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
              Console.WriteLine("There is no game in the 11th position.");
            }

            if (topGames.ContainsKey(5)) 
            {
                topGames[5] = "Raid";
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string favGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {favGame}");

        
            Hashtable capitals = new Hashtable() { 
                {"OKlahoma", "oklahoma City"},
                {"new york", "albany"},
                {"texas", "austin"},
                {"ohio", "colombus"},
            
            };


            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();
        }
    }
}
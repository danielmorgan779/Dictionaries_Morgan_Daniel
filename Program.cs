using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Morgan_Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();//dictionary with int as the kay and a string as the value called topGames
            topGames.Add(1, "Elder Scrolls Online");
            topGames.Add(2, "Left 4 Dead 2");
            topGames.Add(3, "Halo 3 ODST");
            topGames.Add(4, "Half Life 2");
            topGames.Add(5, "Portal 2");
            topGames.Add(6, "Bioshock 2");
            topGames.Add(7, "Morrowind");
            topGames.Add(8, "Oblivion");
            topGames.Add(9, "Terraria");
            topGames.Add(10, "Silent Hill 3"); // Added 10 favorite games to it

            foreach (KeyValuePair<int, string> kvp in topGames) 
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); //loops through topGames and print each pair on a new line
            }

            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!"); //makes sure the key contains 1
            }

            string result = ""; // empty called result

            topGames.TryGetValue(11, out result); //Implements the TryGetValue method on topGames for key 11, and sets output to result string

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position."); // else prints "there is no game in the eleventh postion
            }

            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Rocket League"; //switches the entry object at key 5 with a rocket league
            }

            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames); //new hashtable

            string favGame = (string)hashTable[1]; //string call favGame with the value ok key 1

            Console.WriteLine($"Favorite Game: {favGame}"); //prints favGame

            Hashtable capitals = new Hashtable() { //new hashtable called capitals
                {"Oklahoma", "Oklahoma City" },
                {"New York", "Albany" },
                {"Texas", "Austin" },
                {"Ohio", "Colombus" },
            };

            foreach (DictionaryEntry kvp in capitals) // loops and prints
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}"); //prints out the Dictionary objects key and value on a new line
            }

            capitals.Clear(); //Clears all elements

        }
    }
}
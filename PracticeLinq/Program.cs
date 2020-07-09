using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace PracticeLinq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carNames = new[] { "Chevrolet", "Ford", "Acura", "Nissan" };

            var namesOfCars = from cars in carNames
                              where cars.Contains("r")
                              orderby cars descending
                              select cars;
            foreach (var i in namesOfCars)
            {
                Console.WriteLine(i);
            }



            List <string>  videoGames = new List <string> {"Call of Duty", "Roblox", "Fortnite", "Wolfenstein" };

            IEnumerable<string> myGames = videoGames.OrderByDescending(game => (game.Length));

            foreach (var i in myGames)
            {
                Console.WriteLine(i);
            }

            


        }
    }
}

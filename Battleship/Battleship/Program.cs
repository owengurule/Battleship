using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHighScores();

            //make a new grid
            Grid grid = new Grid();
            //call play game for our grid
            grid.PlayGame();
            
        }
        static void AddHighScore(int playerScore)
        {
            Console.WriteLine("Your name");
            string playerName = Console.ReadLine();
            OwenEntities db = new OwenEntities();
            HighScore newHighScore = new HighScore();
            newHighScore.DateCreated = DateTime.Now;
            newHighScore.Game = "Battleship";
            newHighScore.Name = playerName;
            newHighScore.Score = playerScore;
            db.HighScores.Add(newHighScore);
            db.SaveChanges();

        }

        static void DisplayHighScores()
        {
            Console.Clear();
            Console.WriteLine("BattleShipHighScores");
            Console.WriteLine("--------------------");
            OwenEntities db = new OwenEntities();
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Battleship").Take(10).ToList();

            foreach (HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}, {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score);
            }

        }


    }
}

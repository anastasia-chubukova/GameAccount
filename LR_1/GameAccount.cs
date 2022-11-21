using System.Collections.Generic;
using System;
using System.Text;

namespace LR_1
{
    public class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating
        {
            get
            {
                int Rating = 20;
                foreach (var game in allGames)
                {
                    Rating += game.RatingGame;
                }

                return Rating;
            }
        }
        public int GamesCount { get; set; }

        public List<GameResult> allGames = new List<GameResult>();

        public GameAccount(string name)
        {
            UserName = name;
        }

        public void WinGame(GameAccount opponentName, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can't be < 1");
            }

            this.GamesCount++;
            GameResult Game = new GameResult(opponentName.UserName, 1, rating, DateTime.Now, GamesCount);
            allGames.Add(Game);


        }
        public void LoseGame(GameAccount opponentName, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can't be < 1");
            }
            if (CurrentRating - rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can't be > rating of the player");
            }
            this.GamesCount++;
            GameResult Game = new GameResult(opponentName.UserName, 0, -rating, DateTime.Now, GamesCount);
            allGames.Add(Game);

        }

        public string GetStats()
        {
            var history = new System.Text.StringBuilder();

            int currentRating = 20;
            history.AppendLine("Player name:\tGame rating:\tResult:\t\tGame ID:\tGame Time:");
            foreach (var game in allGames)
            {
                currentRating += game.RatingGame;
                history.AppendLine($"{game.Opponetname}\t\t{currentRating}\t\t{game.Result}\t\t{game.ID}\t\t{DateTime.Now}");
            }

            return history.ToString();

        }
    }
}





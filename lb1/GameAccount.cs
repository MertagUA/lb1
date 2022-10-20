using System;
using System.Collections.Generic;

namespace lb1
{
    public class GameAccount
    {
        public List<string> gamesInfo = new List<string>();
        private string userName;
        private int currentRating;
        private static int gamesCount = 0;

        public GameAccount(string userName, int currentRating)
        {
            if (currentRating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "The rating cannot fall below zero");
            }

            this.userName = userName;
            this.currentRating = currentRating;
        }

        public void WinGame(GameAccount opponentAccount, int Rating)
        {
            if (Rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "The rating cannot be lower then zero");
            }
            if (opponentAccount.currentRating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.currentRating), "The rating cannot fall below zero");
            }
            this.currentRating += Rating;
            opponentAccount.currentRating -= Rating;
            
            gamesInfo.Add(this.userName.ToString());
            gamesInfo.Add("Game number: "+ (++gamesCount).ToString());
            gamesInfo.Add("Character " + this.userName.ToString() + " VS " + "opponent "+opponentAccount.userName.ToString());
            gamesInfo.Add("I won!");
            gamesInfo.Add("Rating for win: "+Rating.ToString());
            gamesInfo.Add(this.userName.ToString()+" rating after win: " + this.currentRating.ToString());
            gamesInfo.Add(opponentAccount.userName.ToString()+" rating after lose: " + opponentAccount.currentRating.ToString());
            gamesInfo.Add("--------------");
        }

        public void LoseGame(GameAccount opponentAccount, int Rating)
        {
            if (Rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Rating), "The rating for which they are playing cannot be under zero or zero");
            }
            if (this.currentRating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(this.currentRating), "Rating cannot be less than one");
            }
            this.currentRating -= Rating;
            opponentAccount.currentRating += Rating;
            
            gamesInfo.Add(this.userName.ToString());
            gamesInfo.Add("Game number: " + (++gamesCount).ToString());
            gamesInfo.Add("Character " + this.userName.ToString() + " VS " + "opponent "+ opponentAccount.userName.ToString());
            gamesInfo.Add("I lost!");
            gamesInfo.Add("Rating for lose: -"+Rating.ToString());
            gamesInfo.Add(this.userName.ToString()+" rating after win: " + this.currentRating.ToString());
            gamesInfo.Add(opponentAccount.userName.ToString()+" rating after lose: " + opponentAccount.currentRating.ToString());
            gamesInfo.Add("--------------");
        }

        public void GetStats()
        {
            for (int i = 0; i < gamesInfo.Count; i++)
            {
                if (gamesInfo[i].Equals(this.userName.ToString()))
                {
                    for(int k = i + 1; k < i + 8; k++)Console.WriteLine(gamesInfo[k]);
                }
            }
        }
    }
}
using System;

namespace Lab2.Models
{
    public class TwentyOne
    {
        public int GameRound { get; set; } = 1;
        public int GameValue { get; set; } = 0;
        public string WinnerText { get; set; } = "";
        public int ComputerPlayed { get; set; }
        
        public void TheGame(int number)
        {
            PlayerTurn(number);
            if (CheckIfWon())
            {
                WinnerText = "Player is the winner";
            }
            CPUTurn();
            if (CheckIfWon())
                WinnerText = "Computer is the winner";
        }

        public void PlayerTurn(int number)
        {
            GameValue += number;
            GameRound++;

        }
        public void CPUTurn()
        {
            var tempNumber = GameValue;
            if (GameValue < 12)
            {
                Random rnd = new Random();
                GameValue += rnd.Next(1, 3);
            }
            if (GameValue >= 12)
            {
                GameValue += (GameValue + 1) % 3 == 0 ? 1 : 2;
            }
            ComputerPlayed = GameValue - tempNumber;
            GameRound++;
        }

        public bool CheckIfWon()
        {
            if (GameValue == 21)
                return true;
            return false;

        }

    }
}
using System;

namespace LR_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameAccount firstPlayer = new GameAccount("Andrew");
            GameAccount secondPlayer = new GameAccount("Den");

            firstPlayer.WinGame(secondPlayer, 7);
            secondPlayer.LoseGame(firstPlayer, 2);

            firstPlayer.GetStats();
            secondPlayer.GetStats();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Game N1");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(firstPlayer.GetStats());
            Console.WriteLine(secondPlayer.GetStats());

            secondPlayer.WinGame(firstPlayer, 3);
            firstPlayer.LoseGame(secondPlayer, 2);

            secondPlayer.WinGame(firstPlayer, 10);
            firstPlayer.LoseGame(secondPlayer, 6);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Statistics of each player");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(firstPlayer.GetStats());
            Console.WriteLine(secondPlayer.GetStats());
        }
    }
}
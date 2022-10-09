using System;
using CardGame.GameType;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();

            Player p1 = new Player("Michael");
            Player p2 = new Player("Henrik");
            Player p3 = new WeakPlayer("Kenny Rogers");
            Player p4 = new Player("Pennywise");
            //            IGameType gameType = new HighHandWins();
            IGameType gameType = new LowHandWins();

            Game game = new Game(deck, gameType);
            game.AcceptPlayers(p1);
            game.AcceptPlayers(p2);
            game.AcceptPlayers(p3);
            game.AcceptPlayers(p4);
            game.Start();

            Console.WriteLine(p1.ShowHand());
            Console.WriteLine(p2.ShowHand());
            Console.WriteLine(p3.ShowHand());
            Console.WriteLine(p4.ShowHand());

            game.AnnounceWinner();
#if DEBUG
            // Wait for keypress before exiting (otherwise the program exits a debug session)
            Console.WriteLine("Press a key to exit.");
            Console.ReadKey();
#endif

        }
    }
}

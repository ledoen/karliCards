using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardAndDeck;
using static System.Console;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.isAceHigh = true;
            Console.WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            Console.WriteLine("Clubs are trumps");
            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ten);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);

            Console.WriteLine($"{card4.ToString()} > {card5.ToString()} ? {card4 > card5}");

            ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examtype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> cards = new List<int[]>();
            List<int[]> hand = new List<int[]>();
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            for (int x = 0; x < suits.Length; x++)
            {
                for (int y = 0; y < values.Length; y++)
                {
                    cards.Add(new int[] { x, y });
                }
            }
            cards = shuffleCards(cards, 0);
            // draw 7 cards
            while (hand.Count < 7)
            {
                hand.Add(drawCard(cards));
                cards = removeTopCardFromDeck(cards);
            }
            // display hand
            displayHand(hand);
            Console.ReadKey();
        }
        static List<int[]> shuffleCards(List<int[]> cards, int count)
        {
            Random rnd = new Random();
            List<int[]> cardstemp = new List<int[]>();

            for (int x = 0;x< 52; x++)
            {
                int[] piece = new int[2];
                int index = rnd.Next(cards.Count);
                cardstemp.Add(cards[index]);
                cards.RemoveAt(index);
            }
            cards = cardstemp;
            // a deck, to be considered shuffled, has to be shuffled at least 7 times
            return cards;
        }
        static int[] drawCard(List<int[]> cards)
        {
            int[] piece = new int[2];
            piece = cards[0];
            
            return piece;
        }
        static List<int[]> removeTopCardFromDeck(List<int[]> cards)
        {
            cards.RemoveAt(0);
            return cards;
        }
        static void displayHand(List<int[]> hand)
        {
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            for(int i = 0; i < 7; i++)
            {
                int[] index = new int[2];
                index = hand[i];
                Console.Write(values[index[1]] + " of ");
                Console.Write(suits[index[0]]);
                Console.WriteLine();
            }
        }
    }
}

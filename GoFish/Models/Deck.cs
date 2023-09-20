using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFish.Models
{
    public class Deck
    {
        private List<Card> cards = new List<Card> {};

        public Deck()
        {
            cards = new List<Card>{};
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            cards = new List<Card>();

            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

            public int CardsCount
            {
                get { return cards.Count; }
            }

            public void ShuffleDeck()
            {
                Random random = new Random();
                cards = cards.OrderBy(card => random.Next()).ToList();
            }
        }
    }

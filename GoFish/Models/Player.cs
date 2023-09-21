using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFish.Models
{

    public class Player
    {
        public string Name {get ; set ;}
        public List<Card> Hand { get; set; }
        public int Id { get; }
    
    public Player(string playerName)
    {
        Name = playerName;
        Hand = new List<Card>{};
        // Id = Id.Count;
        // Pairs = 
    }
    

    public void NewHand(Deck deck)
    {
         for (int i=0; i < 5; i++)
         {
            Hand.Add(deck.DrawCard());
         }       
    }
}
}
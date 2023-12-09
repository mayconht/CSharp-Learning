using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSolution.model
{
    internal class Hand
    {
        List<Card> cards {  get; }

        public Hand(List<Card> cards)
        {
            this.cards = cards;
        }

    }
}

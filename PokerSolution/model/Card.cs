using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSolution.model
{
    class Card
    {
        string rank { get; }
        string suit { get; }

        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{suit} {rank}";
        }

    }
}

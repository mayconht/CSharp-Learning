using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerSolution.model
{
    internal interface IDeck
    {
        Card dealOneCard();

        Hand dealHand(int numberOfCards);
    }
}

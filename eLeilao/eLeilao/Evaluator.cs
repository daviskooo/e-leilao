using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    public class Evaluator
    {
        public double highestOffer = Double.MaxValue;
        public double lowestOffer = Double.MinValue;

        public void Evaluation(Auction auction)
        {
            foreach(var offer in auction.Offers)
            {
                if (offer.Value > highestOffer)
                {
                    highestOffer = offer.Value;
                }
                else if(offer.Value < lowestOffer)
                {
                    lowestOffer = offer.Value;
                }
            }
        }
    }
}

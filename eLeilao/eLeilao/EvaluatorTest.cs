using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    class EvaluatorTest
    {
        static void Main(string[] args)
        {
            User user1 = new User("User 1");
            User user2 = new User("User 2");
            User user3 = new User("User 3");

            Auction auction = new Auction("Product 1");
            auction.Proposal(new Offer(user1, 280.0));
            auction.Proposal(new Offer(user2, 300.0));
            auction.Proposal(new Offer(user3, 800.0));

            Evaluator evaluator = new Evaluator();
            evaluator.Evaluation(auction);

            Console.WriteLine(evaluator.highestOffer);
            Console.WriteLine(evaluator.lowestOffer);
            Console.ReadKey();
        }
    }
}

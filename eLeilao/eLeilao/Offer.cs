using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    public class Offer
    {
        public User User { get; private set; }
        public double Value { get; private set; }

        public Offer(User user, double value)
        {
            this.User = user;
            this.Value = value;
        }
    }
}

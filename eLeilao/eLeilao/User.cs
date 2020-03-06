using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLeilao
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public User(string name): this(0, name) { }

        public User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

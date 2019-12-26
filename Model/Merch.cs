using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseShop.Model
{
    class Merch
    {
        public string name { get; set; }

        public Merch(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseShop.Model
{
    class Bucket
    {
        private int capacity;
        private List<Merch> merch;

        public Bucket(int capacity)
        {
            this.capacity = capacity;
            this.merch = new List<Merch>();
        }

        public void insert(Merch merch)
        {
            this.merch.Add(merch);
        }

        public void remove(int position)
        {
            this.merch.RemoveAt(position);
        }

        public List<Merch> findAll()
        {
            return this.merch;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

        public int countItems()
        {
            return this.merch.Count();
        }

    }
}

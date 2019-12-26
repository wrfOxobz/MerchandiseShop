using MerchandiseShop.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseShop.Model
{
    class Seller
    {
        private string name;
        private BucketController bucket;

        public Seller(string name, BucketController bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }

        public List<Merch> findAll()
        {
            return this.bucket.findAll();
        }

        public void addMerch(Merch merch)
        {
            this.bucket.addMerch(merch);
        }

        internal void removeMerch(Merch selectedItem)
        {
            this.bucket.removeMerch(selectedItem);
        }
    }
}

using MerchandiseShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseShop.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addMerch(Merch merch)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Oops, the bucket is full");
            }
            else
            {
                this.bucket.insert(merch);
                eventListener.onSucceed("Yay, added successfully");
            }
        }

        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void removeMerch(Merch merch)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == merch.name)
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yey, removed successfully");
                }
            }
        }

        public List<Merch> findAll()
        {
            return this.bucket.findAll();
        }
    }
}

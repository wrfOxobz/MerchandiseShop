﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchandiseShop
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}

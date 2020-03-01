﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Membership_app.Areas.Admin.Models
{
    public class EditButtonModel
    {
        public int ItemId { get; set; }

        public int ProductId { get; set; }

        public int SubscrtiptionId { get; set; }

        public string Link {
            get
            {
                var s = new StringBuilder("?");
                if (ItemId > 0) s.Append(String.Format("{0}={1}&", "itemId", ItemId));
                if (ItemId > 0) s.Append(String.Format("{0}={1}&", "productId", ProductId));
                if (ItemId > 0) s.Append(String.Format("{0}={1}&", "subscriptionId", SubscrtiptionId));

                return s.ToString().Substring(0, s.Length - 1);
            }
        }
    }
}
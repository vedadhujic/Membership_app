using Membership_app.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Membership_app.Models
{
    public class UserSubscriptionViewModel
    {
        public ICollection<Subscription> Subscriptions { get; set; }

        public ICollection<UserSubscriptionModel> UserSubscriptions { get; set; }

        public bool DisableDropDown { get; set; }

        public string UserId { get; set; }

        public int SubscriptionId { get; set; }
    }
}
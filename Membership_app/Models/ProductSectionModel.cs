using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Membership_app.Models
{
    public class ProductSectionModel
    {
        public string Title { get; set; }

        public List<ProductSection> Sections { get; set; }
    }
}
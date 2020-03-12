using Membership_app.Extensions;
using Membership_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Membership_app.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
            var sections = await SectionExtensions.GetProductSectionAsync(id, userId);

            return View(sections);
        }
    }
}
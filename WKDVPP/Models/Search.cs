using Microsoft.AspNetCore.Mvc;
using WKDVPP.Data;

namespace WKDVPP.Models
{
	public class Search:ViewComponent
	{
        private readonly WKDVPPContext _context;

        public Search(WKDVPPContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Category.ToList());
        }
    }
}

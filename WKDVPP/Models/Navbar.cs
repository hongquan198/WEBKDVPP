using Microsoft.AspNetCore.Mvc;
using WKDVPP.Data;

namespace WKDVPP.Models
{
	
	public class Navbar:ViewComponent
	{
        private readonly WKDVPPContext _context;

        public Navbar(WKDVPPContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke() 
		{
			return View(_context.Category.ToList());
		}
	}
}

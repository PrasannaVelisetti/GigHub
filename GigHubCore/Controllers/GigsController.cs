using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GigHubCore.Data;
using GigHubCore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GigHubCore.Controllers
{
    public class GigsController : Controller
    {
        private readonly DataContext _context;
      
        public GigsController()
        {
            _context = new DataContext();
        }

        public IActionResult Create()
        {
            var gigViewModel = new GigViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View(gigViewModel);
        }
    }
}

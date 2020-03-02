using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CNC.Controllers
{
    public class DiscussionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using StajProje.Models;
using System.Diagnostics;
using Repositories.Extensions;

namespace StajProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceManager _manager;

        public HomeController(ILogger<HomeController> logger, 
            IServiceManager manager)
        {
            _logger = logger;
            _manager = manager;
        }

        public IActionResult Index(RickParameters r)
        {
            var rick = _manager.RickService.GetAllRickDetails(r);
            var pagination = new Pagination()
            {
                CurrenPage = r.PageNumber,
                ItemsPerPage = r.PageSize,
                TotalItems = _manager.RickService.GetAllRick(false).Count()
            };
            return View(new RickListViewModel()
            {
                RickResult = rick,
                Pagination = pagination
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

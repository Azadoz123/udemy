using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class Products2Controller : Controller
    {
        private readonly IProductService _services;

        public Products2Controller(IProductService services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
          var CustomResponse=  _services.GetProductsWithCategory();
            return View();
        }
    }
}

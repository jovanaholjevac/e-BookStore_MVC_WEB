using e_BookStore.DataAccess.Repository.IRepository;
using e_BookStore.Models;
using e_BookStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace e_BookStoreWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        /*public IActionResult Index()
        {
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties:"Category");
            return View(productList);
        }*/
        public IActionResult Index(string searchString, int pageNumber = 1, int pageSize = 8)
        {
            ViewData["CurrentFilter"] = searchString;

            IEnumerable<Product> products;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = _unitOfWork.Product.GetAll(includeProperties: "Category")
                            .Where(p => p.Title.ToLower().Contains(searchString.ToLower()));
            }
            else
            {
                products = _unitOfWork.Product.GetAll(includeProperties: "Category");
            }

            var paginatedProducts = PaginatedList<Product>.Create(products, pageNumber, pageSize);

            return View(paginatedProducts);
        }

        public IActionResult Details(int productId)
        {
            ShoppingCart cart = new()
            {
                Product = _unitOfWork.Product.Get(u=>u.Id== productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId
        };
        
            return View(cart);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;

            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.ApplicationUserId == userId &&
            u.ProductId == shoppingCart.ProductId);

            if (cartFromDb != null)
            {
                //shopping cart exists
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                
            }
            else
            {
                //add cart record
                _unitOfWork.ShoppingCart.Add(shoppingCart);
            }

            _unitOfWork.Save();
            TempData["success"] = "Cart updated successfully";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index2(string searchString, int pageNumber = 1, int pageSize = 8)
        {
            return Index(searchString, pageNumber, pageSize);
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

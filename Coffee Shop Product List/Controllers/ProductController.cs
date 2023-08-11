using Coffee_Shop_Product_List.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Coffee_Shop_Product_List.Controllers
{
    public class ProductController : Controller
    {
        private ProductDbContext _ProductDbContext = new ProductDbContext();
        public IActionResult Index()
        {
            List<ProductTable> result = _ProductDbContext.ProductTables.ToList();
            return View(result);
        }

        //public IActionResult ShowProduct(ProductTable p)
        //{
        //    _ProductDbContext.ProductTable.Add(p);
        //    _ProductDbContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        public IActionResult ProductDetails(int id)
        {
            ProductTable p = _ProductDbContext.ProductTables.FirstOrDefault(x => x.Id == id);
            //gets the post with the matching id and returns it to the view

            //option 1 is most efficient make a new model that contains all you want to bring down, 
            //you can only send one object into the view
            //Option 2, send it thorugh a viewdata
            ViewBag.DetailsTables = _ProductDbContext.DetailsTables.Where(c => c.ProductId == id).ToList();
            return View(p);
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ProductControllers : Controller
    {
        // GET: Controllers
        ProductManager productManager  = new ProductManager(new EfProductDal());
        public ActionResult Index()
        {
            var values = productManager.TGetList();
            return View(values);
        }

    }
}

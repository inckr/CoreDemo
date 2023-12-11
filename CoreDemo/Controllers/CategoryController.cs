using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        //CategoryManager sınıfından deger türetme
        //CategoryManager içinde ICategoryDal'ı karşılayacak bir deger gondeririz
        CategoryManager cm = new CategoryManager(new EfCategoryRepository()); 
        //Böylece  oluşturudugumuz cm aracılıgı ile bütün metotlara erişim sağlanır
        public IActionResult Index()
        {
           var values = cm.GetList();
            return View(values);
        }
    }
}

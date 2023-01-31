using LabViewComponentPartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabViewComponentPartialView.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                Id = 1,
                Title = "What is ASP.NET Core",
                Author = "Shailendra Chauhan",
                Body = "ASP.NET Core is an open-source framework for building UI and  Api"

            };
            return View(model);
            
        }
    }
}

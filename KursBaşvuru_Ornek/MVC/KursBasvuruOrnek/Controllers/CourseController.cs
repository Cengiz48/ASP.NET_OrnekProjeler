using KursBasvuruOrnek.Models;
using Microsoft.AspNetCore.Mvc;

namespace KursBasvuruOrnek.Controllers
{

    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            var model= Repository.Applications;

            return View(model);
        }
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Candidate model)
        {
            if(Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is Already an Application");
            }

            if(ModelState.IsValid)
            {

            Repository.Add(model);
            return View("FeedBack",model);
            }
            else{
                return View();
            }
        }

        

    }


}
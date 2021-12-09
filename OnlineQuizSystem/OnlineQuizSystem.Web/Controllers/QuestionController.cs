namespace OnlineQuizSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OnlineQuizSystem.Web.Models.Questions;

    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(QuestionFormModel question)
        {
            if (!ModelState.IsValid)
            {
                return View(question);
            }



            return RedirectToAction();
        }
    }
}

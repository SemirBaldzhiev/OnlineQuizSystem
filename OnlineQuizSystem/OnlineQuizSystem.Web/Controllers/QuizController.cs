namespace OnlineQuizSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OnlineQuizSystem.Web.Data;
    using OnlineQuizSystem.Web.Data.Models;
    using OnlineQuizSystem.Web.Models.Quizzes;

    public class QuizController : Controller
    {
        private readonly QuizSystemDbContext context;

        public QuizController(QuizSystemDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(QuizFormModel quiz)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var cerateQuiz = new Quiz
            {
                Name = quiz.Name
            };

            context.Quizzes.Add(cerateQuiz);





            return RedirectToAction();
        }
    }
}

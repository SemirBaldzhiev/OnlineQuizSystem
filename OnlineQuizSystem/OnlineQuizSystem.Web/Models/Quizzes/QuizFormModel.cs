namespace OnlineQuizSystem.Web.Models.Quizzes
{
    using System.ComponentModel.DataAnnotations;

    public class QuizFormModel
    {
        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Name { get; set; }

        public IEnumerable<QuestionFormModel> Questions { get; set; }
    }
}

namespace OnlineQuizSystem.Web.Models.Questions
{
    using OnlineQuizSystem.Web.Models.Answers;
    using System.ComponentModel.DataAnnotations;

    public class QuestionFormModel
    {
        [Required]
        [MaxLength(500)]
        public string QuestionText { get; set; }
        public int QuizId { get; set; }
    }
}

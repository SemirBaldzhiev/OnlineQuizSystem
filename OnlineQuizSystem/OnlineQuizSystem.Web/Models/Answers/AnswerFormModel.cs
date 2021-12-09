namespace OnlineQuizSystem.Web.Models.Answers
{
    using System.ComponentModel.DataAnnotations;

    public class AnswerFormModel
    {
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string AnswerText { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}

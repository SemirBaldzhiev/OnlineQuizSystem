namespace OnlineQuizSystem.Web.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AnswerText { get; set; }

        [Required]
        public bool IsCorrect { get; set; }
    }
}

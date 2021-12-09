namespace OnlineQuizSystem.Web.Data.Models
{
    using OnlineQuizSystem.Web.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Question
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string QuestionText { get; set; }

        [Required]
        public QuestionType QuestionType { get; set; }

        [ForeignKey(nameof(Quiz))]
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }

    }
}

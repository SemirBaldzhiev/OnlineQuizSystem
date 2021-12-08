namespace OnlineQuizSystem.Web.Data.Models
{
    using OnlineQuizSystem.Web.Data.Models.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Question
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string QuestionText { get; set; }

        [Required]
        public QuestionType QuestionType { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }

    }
}

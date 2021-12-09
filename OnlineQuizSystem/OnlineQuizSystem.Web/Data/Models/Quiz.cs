namespace OnlineQuizSystem.Web.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Quiz
    {
        public Quiz()
        {
            this.Questions = new HashSet<Question>();
        }

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}

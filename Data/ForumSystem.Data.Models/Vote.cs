namespace ForumSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ForumSystem.Data.Common.Models;

    public class Vote : BaseModel<int>
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string UserId { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }

        public VoteType Type { get; set; }
    }
}

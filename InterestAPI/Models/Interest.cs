using InterestAPI.Models.ConnectionTables;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterestAPI.Models
{
    public class Interest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterestId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50)]
        public string Title { get; set; } = default!;

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(100)]
        public string Description { get; set; } = default!;

        //public virtual ICollection<InterestList>? InterestLists { get; set; }
    }
}

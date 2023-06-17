using InterestAPI.Models.ConnectionTables;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterestAPI.Models
{
    public class InterestLink
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterestLinkId { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(100)]
        public string Description { get; set; } = default!;

        [Required(ErrorMessage = "Link url is required")]
        [StringLength(200)]
        public string InterestLinkURL { get; set; } = default!;

        //public virtual ICollection<InterestList>? InterestLists { get; set; }
    }
}

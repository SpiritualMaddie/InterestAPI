using System.ComponentModel.DataAnnotations.Schema;

namespace InterestAPI.Models.ConnectionTables
{
    public class InterestList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterestListId { get; set; }

        [Required(ErrorMessage = "Person id is required.")]
        [ForeignKey("Person")]
        public int FK_PersonId { get; set; }
        public virtual Person? Persons { get; set; }

        [Required(ErrorMessage = "Interest id is required.")]
        [ForeignKey("Interest")]
        public int FK_InterestId { get; set; }
        public virtual Interest? Interests { get; set; }

        [ForeignKey("InterestLink")]
        public int? FK_InterestLinkId { get; set; }
        public virtual InterestLink? InterestLinks { get; set; }
    }
}

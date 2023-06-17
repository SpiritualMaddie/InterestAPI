
using InterestAPI.Models.ConnectionTables;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterestAPI.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50)]
        public string FirstName { get; set; } = default!;

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50)]
        public string LastName { get; set; } = default!;

        [NotMapped]
        public string FullName => (FirstName + " " + LastName);

        [StringLength(15)]
        public string? Phone { get; set; }

        [StringLength(50)]
        public string? Email { get; set; }

        //public virtual ICollection<InterestList>? InterestLists { get; set; }
    }
}

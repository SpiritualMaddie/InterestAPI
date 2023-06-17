using System.ComponentModel.DataAnnotations.Schema;

namespace InterestAPI.Models.DTO
{
    public class NewInterestListDTO
    {
        //public int? InterestListId { get; set; }

        [Required(ErrorMessage = "Person id is required.")]
        public int FK_PersonId { get; set; }

        [Required(ErrorMessage = "Interest id is required.")]
        public int FK_InterestId { get; set; }
        public string? InterestTitle { get; set; }

        public int? FK_InterestLinkId { get; set; }
        public string? LinkDescription { get; set; } = default!;
        public string? InterestLinkURL { get; set; } = default!;
    }
}

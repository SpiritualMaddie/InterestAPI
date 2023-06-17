namespace InterestAPI.Models.DTO
{
    public class AddPersonsInterestDTO
    {
        [Required(ErrorMessage = "Person id is required.")]
        public int FK_PersonId { get; set; }

        [Required(ErrorMessage = "Interest id is required.")]
        public int FK_InterestId { get; set; }
        public string? InterestTitle { get; set; }
    }
}

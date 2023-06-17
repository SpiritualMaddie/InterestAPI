

namespace InterestAPI.Services.IServices
{
    public interface IInterestListService
    {
        Task<List<Interest>> GetInterestsForPerson(int personId);
        Task<List<InterestLink>> GetPersonsLinks(int personId);
        Task<ActionResult<AddPersonsInterestDTO>> AddPersonsInterest(int personId, int interestId);
    }
}



namespace InterestAPI.Services.IServices
{
    public interface IInterestLinkService
    {
        Task<ActionResult<NewInterestListDTO>>? AddLinksToPersonInterest(InterestLink request, int personId, int interestId);
        //Task<List<InterestLink>> GetAllLinksAsync();
        //Task<InterestLink> AddLink();
        //Task<InterestLink>? GetSpecificLink(int id);
        //Task<List<InterestLink>>? UpdateLink(int id, Person person);
        //Task<List<InterestLink>>? DeleteLink(int id);
    }
}

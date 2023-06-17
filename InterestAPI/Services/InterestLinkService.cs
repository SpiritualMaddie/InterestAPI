

namespace InterestAPI.Services
{
    public class InterestLinkService : IInterestLinkService
    {
        private readonly ApplicationDbContext _context;
        public InterestLinkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<NewInterestListDTO>>? AddLinksToPersonInterest(InterestLink request, int personId, int interestId)
        {
            if (request is null)
            {
                return null;
            }
            else
            {
                //Adds a new InterestLink

                InterestLink interestLink = new InterestLink();

                interestLink.InterestLinkURL = request.InterestLinkURL;
                interestLink.Description = request.Description;

                _context.InterestLinks.Add(interestLink);
                await _context.SaveChangesAsync();

                // Adds a new InterestList

                InterestList interestList = new InterestList();

                interestList.FK_PersonId = personId;
                interestList.FK_InterestId = interestId;
                interestList.FK_InterestLinkId = interestLink.InterestLinkId;

                _context.InterestLists.Add(interestList);
                await _context.SaveChangesAsync();

                // Get Title for Interest

                var interest = await _context.Interests
                    .Where(i => i.InterestId == interestId)
                    .Select(t => t.Title)
                    .FirstOrDefaultAsync();

                // Display with DTO

                NewInterestListDTO newInterestListDTO = new NewInterestListDTO();
                newInterestListDTO.FK_PersonId = personId;
                newInterestListDTO.FK_InterestId = interestId;
                newInterestListDTO.FK_InterestLinkId = interestList.FK_InterestLinkId;
                newInterestListDTO.InterestTitle = interest;
                newInterestListDTO.InterestLinkURL = interestLink.InterestLinkURL;
                newInterestListDTO.LinkDescription = interestLink.Description;

                return newInterestListDTO;
            }
        }
    }
}

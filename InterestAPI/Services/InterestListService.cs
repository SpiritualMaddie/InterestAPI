

namespace InterestAPI.Services
{
    public class InterestListService : IServices<InterestList>, IInterestListService
    {
        private readonly ApplicationDbContext _context;
        public InterestListService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<InterestList> Add(InterestList item)
        {
            if (item is null)
            {
                return null;
            }
            else
            {
                InterestList interestList = new InterestList();
                interestList.InterestListId = item.InterestListId;
                interestList.FK_PersonId = item.FK_PersonId;
                interestList.FK_InterestId = item.FK_InterestId;
                interestList.FK_InterestLinkId = item?.FK_InterestLinkId;

                _context.InterestLists.Add(interestList);
                await _context.SaveChangesAsync();

                return interestList;
            }
        }

        public async Task<ActionResult<AddPersonsInterestDTO>> AddPersonsInterest(int personId, int interestId)
        {
            // Adds a new InterestList

            InterestList interestList = new InterestList();
            interestList.FK_PersonId = personId;
            interestList.FK_InterestId = interestId;

            _context.InterestLists.Add(interestList);
            await _context.SaveChangesAsync();


            // Get Title for Interest

            var interest = await _context.Interests
                .Where(i => i.InterestId == interestId)
                .Select(t => t.Title)
                .FirstOrDefaultAsync();

            // Display with DTO

            AddPersonsInterestDTO addPersonsInterestDTO = new AddPersonsInterestDTO();
            addPersonsInterestDTO.FK_PersonId = personId;
            addPersonsInterestDTO.FK_InterestId = interestId;
            addPersonsInterestDTO.InterestTitle = interest;

            return addPersonsInterestDTO;
        }

        public async Task<List<InterestList>>? Delete(int id)
        {
            var item = await _context.InterestLists.FindAsync(id);

            if (item is null)
            {
                return null;
            }
            else
            {
                _context.InterestLists.Remove(item);
                await _context.SaveChangesAsync();

                return await _context.InterestLists.ToListAsync();
            }
        }

        public async Task<List<InterestList>> GetAll()
        {
            return await _context.InterestLists.ToListAsync();
        }

        public async Task<List<Interest>> GetInterestsForPerson(int personId)
        {
            var personInterest = await (
                from i in _context.InterestLists
                join p in _context.Persons on i.FK_PersonId equals p.PersonId
                join pi in _context.Interests on i.FK_InterestId equals pi.InterestId
                where i.FK_PersonId == personId
                select pi).ToListAsync();

            if (!personInterest.Any())
            {
                return null;
            }
            else
            {

                return personInterest;
            }
        }

        public async Task<List<InterestLink>> GetPersonsLinks(int personId)
        {
            var personLinks = await(
                from i in _context.InterestLists
                join p in _context.Persons on i.FK_PersonId equals p.PersonId
                join l in _context.InterestLinks on i.FK_InterestLinkId equals l.InterestLinkId
                where i.FK_PersonId == personId
                select l).ToListAsync();

            if (!personLinks.Any())
            {
                return null;
            }
            else
            {

                return personLinks;
            }
        }

        public async Task<InterestList>? GetSpecific(int id)
        {
            var item = await _context.InterestLists.FindAsync(id);

            if (item is null)
            {
                return null;
            }
            else
            {
                return item;
            }
        }

        public async Task<InterestList>? Update(int id, InterestList request)
        {
            var item = await _context.InterestLists.FindAsync(id);

            if (item is null)
            {
                return null;
            }
            else
            {
                item.InterestListId = id;
                item.FK_PersonId = request.FK_PersonId;
                item.FK_InterestId = request.FK_InterestId;
                item.FK_InterestLinkId = request?.FK_InterestLinkId;

                await _context.SaveChangesAsync();

                return item;
            }
        }
    }
}

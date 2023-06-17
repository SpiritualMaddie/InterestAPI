

namespace InterestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestListController : ControllerBase
    {
        private readonly IServices<InterestList> _services;
        private readonly IInterestListService _interestListService;

        public InterestListController(IServices<InterestList> services, IInterestListService interestListService)
        {
            _services = services;
            _interestListService = interestListService;
        }

        [HttpGet("GetInterestsForPerson{personId}")]
        public async Task<ActionResult<List<Interest>>> GetInterestsForPerson(int personId)
        {
            var result = await _interestListService.GetInterestsForPerson(personId);

            if (result is null)
            {
                return NotFound("No interests found!");
            }
            return Ok(result);
        }

        [HttpGet("GetPersonsLinks{personId}")]
        public async Task<ActionResult<List<InterestLink>>> GetPersonsLinks(int personId)
        {
            var result = await _interestListService.GetPersonsLinks(personId);

            if (result is null)
            {
                return NotFound("No links found!");
            }
            return Ok(result);
        }

        [HttpPost("AddPersonsInterest")]
        public async Task<ActionResult<AddPersonsInterestDTO>> AddPersonsInterest(int personId, int interestId)
        {
            var result = await _interestListService.AddPersonsInterest(personId, interestId);
            return Ok(result);
        }

        //[HttpGet("GetAllInterestList")]
        //public async Task<ActionResult<List<InterestList>>> GetAll()
        //{
        //    return await _services.GetAll();
        //}

        //[HttpGet("GetSpecificInterestList{id}")]
        //public async Task<ActionResult<InterestList>>? GetSpecific(int id)
        //{
        //    var result = await _services.GetSpecific(id);

        //    if (result is null)
        //    {
        //        return NotFound("InterestList not found!");
        //    }
        //    return Ok(result);
        //}


        //[HttpPost("AddInterestList")]
        //public async Task<ActionResult<NewInterestListDTO>> Add(InterestList item)
        //{
        //    var result = await _services.Add(item);
        //    return Ok(result);
        //}

        //[HttpPut("UpdateInterestList{id}")]
        //public async Task<ActionResult<InterestList>>? Update(int id, InterestList request)
        //{
        //    var item = await _services.Update(id, request);

        //    if (item is null)
        //    {
        //        return NotFound("InterestList not found!");
        //    }
        //    return Ok(item);
        //}

        //[HttpDelete("DeleteInterestList{id}")]
        //public async Task<ActionResult<List<InterestList>>>? Delete(int id)
        //{
        //    var result = await _services.Delete(id);

        //    if (result is null)
        //    {
        //        return NotFound("InterestList not found!");
        //    }
        //    else
        //    {
        //        return Ok(result);
        //    }
        //}
    }
}



namespace InterestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestLinkController : ControllerBase
    {
        private readonly IInterestLinkService _services;

        public InterestLinkController(IInterestLinkService services)
        {
            _services = services;
        }

        [HttpPost("AddLinksToPersonInterest{personId}/{interestId}")]
        public async Task<ActionResult<NewInterestListDTO>>? AddLinksToPersonInterest(InterestLink request, int personId, int interestId)
        {
            var result = await _services.AddLinksToPersonInterest(request, personId, interestId);
            return Ok(result);
        }
    }
}

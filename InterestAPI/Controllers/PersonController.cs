

namespace InterestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IServices<Person> _services;

        public PersonController(IServices<Person> services)
        {
            _services = services;
        }

        [HttpGet("GetAllPersons")]
        public async Task<ActionResult<List<Person>>> GetAllPersons()
        {
            return await _services.GetAll();
        }

        //[HttpGet("GetSpecificPerson{id}")]
        //public async Task<ActionResult<Person>>? GetSpecificPerson(int id)
        //{
        //    var result = await _services.GetSpecific(id);

        //    if (result is null)
        //    {
        //        return NotFound("Person not found!");
        //    }
        //    return Ok(result);
        //}

        //[HttpPost("AddPerson")]
        //public async Task<ActionResult<Person>> AddPerson(Person person)
        //{
        //    var result = await _services.Add(person);
        //    return Ok(result);
        //}

        //[HttpPut("UpdatePerson{id}")]
        //public async Task<ActionResult<Person>>? UpdatePerson(int id, Person request)
        //{
        //    var person = await _services.Update(id, request);

        //    if (person is null)
        //    {
        //        return NotFound("Person not found!");
        //    }
        //    return Ok(person);
        //}

        //[HttpDelete("DeletePerson{id}")]
        //public async Task<ActionResult<List<Person>>>? DeletePerson(int id)
        //{
        //    var result = await _services.Delete(id);

        //    if (result is null)
        //    {
        //        return NotFound("Person not found!");
        //    }
        //    else
        //    {
        //        return Ok(result);
        //    }
        //}
    }
}

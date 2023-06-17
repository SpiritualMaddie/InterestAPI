

namespace InterestAPI.Services
{
    public class PersonService : IServices<Person>
    {
        private readonly ApplicationDbContext _context;
        public PersonService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Person> Add(Person person)
        {
            _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>>? Delete(int id)
        {
            var person = await _context.Persons.FindAsync(id);

            if (person is null)
            {
                return null;
            }
            else
            {
                _context.Persons.Remove(person);
                await _context.SaveChangesAsync();

                return await _context.Persons.ToListAsync();
            }
        }

        public async Task<List<Person>> GetAll()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person>? GetSpecific(int id)
        {
            var person = await _context.Persons.FindAsync(id);

            if (person is null)
            {
                return null;
            }
            else
            {
                return person;
            }
        }

        public async Task<Person>? Update(int id, Person request)
        {
            var person = await _context.Persons.FindAsync(id);

            if (person is null)
            {
                return null;
            }
            else
            {
                person.FirstName = request.FirstName;
                person.LastName = request.LastName;
                person.Email = request?.Email;
                person.Phone = request?.Phone;

                await _context.SaveChangesAsync();

                return person;
            }
        }
    }
}

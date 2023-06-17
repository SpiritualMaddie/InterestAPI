

using InterestAPI.Models.ConnectionTables;

namespace InterestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<InterestLink> InterestLinks { get; set; }
        public DbSet<InterestList> InterestLists { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=BLUEBOX;Database=InterestApiDb;Trusted_Connection=True;TrustServerCertificate=True;encrypt=False;MultipleActiveResultSets=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(
                    new Person
                    {
                        PersonId = 1,
                        FirstName = "John",
                        LastName = "Smith",
                        Phone = "123-456-7890",
                        Email = "john.smith@example.com"
                    },
                    new Person
                    {
                        PersonId = 2,
                        FirstName = "Emily",
                        LastName = "Johnson",
                        Phone = "987-654-3210",
                        Email = "emily.johnson@example.com"
                    },
                    new Person
                    {
                        PersonId = 3,
                        FirstName = "Michael",
                        LastName = "Davis",
                        Phone = "555-123-4567",
                        Email = "michael.davis@example.com"
                    },
                    new Person
                    {
                        PersonId = 4,
                        FirstName = "Sarah",
                        LastName = "Thompson",
                        Phone = "789-456-1230",
                        Email = "sarah.thompson@example.com"
                    },
                    new Person
                    {
                        PersonId = 5,
                        FirstName = "David",
                        LastName = "Rodriguez",
                        Phone = "246-802-3579",
                        Email = "david.rodriguez@example.com"
                    },
                    new Person
                    {
                        PersonId = 6,
                        FirstName = "Jennifer",
                        LastName = "Martinez",
                        Phone = "345-678-9012",
                        Email = "jennifer.martinez@example.com"
                    },
                    new Person
                    {
                        PersonId = 7,
                        FirstName = "Christopher",
                        LastName = "Wilson",
                        Phone = "678-901-2345",
                        Email = "christopher.wilson@example.com"
                    },
                    new Person
                    {
                        PersonId = 8,
                        FirstName = "Jessica",
                        LastName = "Anderson",
                        Phone = "987-654-3210",
                        Email = "jessica.anderson@example.com"
                    },
                    new Person
                    {
                        PersonId = 9,
                        FirstName = "Matthew",
                        LastName = "Thomas",
                        Phone = "123-456-7890",
                        Email = "matthew.thomas@example.com"
                    },
                   new Person
                   {
                        PersonId = 10,
                        FirstName = "Ashley",
                        LastName = "Walker",
                        Phone = "456-789-0123",
                        Email = "ashley.walker@example.com"
                   }
                );


            modelBuilder.Entity<Interest>()
                .HasData(
                    new Interest
                    {
                        InterestId = 1,
                        Title = "Photography",
                        Description = "Capturing moments through the lens"
                    },

                    new Interest
                    {
                        InterestId = 2,
                        Title = "Cooking",
                        Description = "Exploring flavors and creating delicious meals"
                    },

                    new Interest
                    {
                        InterestId = 3,
                        Title = "Gardening",
                        Description = "Growing plants and creating beautiful landscapes"
                    },

                    new Interest
                    {
                        InterestId = 4,
                        Title = "Hiking",
                        Description = "Exploring nature and enjoying scenic trails"
                    },

                    new Interest
                    {
                        InterestId = 5,
                        Title = "Painting",
                        Description = "Expressing creativity through colors and brushstrokes"
                    },

                    new Interest
                    {
                        InterestId = 6,
                        Title = "Reading",
                        Description = "Immersing in captivating stories and expanding knowledge"
                    },

                    new Interest
                    {
                        InterestId = 7,
                        Title = "Playing guitar",
                        Description = "Creating melodies and expressing emotions through music"
                    }
                );


            modelBuilder.Entity<InterestLink>()
                .HasData(
                    new InterestLink
                    {
                        InterestLinkId = 1,
                        InterestLinkURL = "https://en.wikipedia.org/wiki/Photography#:~:text=Photography%20is%20the%20art%2C%20application,material%20such%20as%20photographic%20film.",
                        Description = "Photography"
                    },

                    new InterestLink
                    {
                        InterestLinkId = 2,
                        InterestLinkURL = "https://www.smashingmagazine.com/2009/04/the-ultimate-photography-round-up/",
                        Description = "Photography"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 3,
                        InterestLinkURL = "https://www.gardendesign.com/how-to/",
                        Description = "Gardening"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 4,
                        InterestLinkURL = "https://www.pinterest.se/ideas/paintings/938071044570/",
                        Description = "Painting"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 5,
                        InterestLinkURL = "https://kleki.com/y",
                        Description = "Painting"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 6,
                        InterestLinkURL = "https://yousician.com/blog/how-to-play-guitar",
                        Description = "Playing guitar"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 7,
                        InterestLinkURL = "https://guitarsonmain.com/blogs/news/the-benefits-of-playing-guitar-how-it-can-improve-your-life",
                        Description = "Playing guitar"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 8,
                        InterestLinkURL = "https://www.thepioneerwoman.com/food-cooking/",
                        Description = "Cooking"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 9,
                        InterestLinkURL = "https://www.alexmakesmeals.com/",
                        Description = "Cooking"
                    },
                    new InterestLink
                    {
                        InterestLinkId = 10,
                        InterestLinkURL = "https://www.reading.ac.uk/",
                        Description = "Reading"
                    }
                );
            modelBuilder.Entity<InterestList>()
                .HasData(
                    new InterestList
                    {
                        InterestListId = 1,
                        FK_PersonId = 1,
                        FK_InterestId = 1,
                        FK_InterestLinkId = 1 
                    },
                    new InterestList
                    {
                        InterestListId = 2,
                        FK_PersonId = 2,
                        FK_InterestId = 1,
                        FK_InterestLinkId = 2
                    },
                    new InterestList
                    {
                        InterestListId = 3,
                        FK_PersonId = 3,
                        FK_InterestId = 3,
                        FK_InterestLinkId = 3
                    },
                    new InterestList
                    {
                        InterestListId = 4,
                        FK_PersonId = 4,
                        FK_InterestId = 4,
                        FK_InterestLinkId = null
                    },
                    new InterestList
                    {
                        InterestListId = 5,
                        FK_PersonId = 5,
                        FK_InterestId = 7,
                        FK_InterestLinkId = 7
                    },
                    new InterestList
                    {
                        InterestListId = 6,
                        FK_PersonId = 5,
                        FK_InterestId = 5,
                        FK_InterestLinkId = 5
                    },
                    new InterestList
                    {
                        InterestListId = 7,
                        FK_PersonId = 5,
                        FK_InterestId = 3,
                        FK_InterestLinkId = 3
                    },
                    new InterestList
                    {
                        InterestListId = 8,
                        FK_PersonId = 6,
                        FK_InterestId = 2,
                        FK_InterestLinkId = 8
                    },
                    new InterestList
                    {
                        InterestListId = 9,
                        FK_PersonId = 7,
                        FK_InterestId = 6,
                        FK_InterestLinkId = 10
                    },
                    new InterestList
                    {
                        InterestListId = 10,
                        FK_PersonId = 8,
                        FK_InterestId = 2,
                        FK_InterestLinkId = null
                    }
                );
        }
    }
}

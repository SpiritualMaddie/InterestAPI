using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InterestAPI.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterestLinks",
                columns: table => new
                {
                    InterestLinkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InterestLinkURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestLinks", x => x.InterestLinkId);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "InterestLists",
                columns: table => new
                {
                    InterestListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonsPersonId = table.Column<int>(type: "int", nullable: true),
                    FK_InterestId = table.Column<int>(type: "int", nullable: false),
                    InterestsInterestId = table.Column<int>(type: "int", nullable: true),
                    FK_InterestLinkId = table.Column<int>(type: "int", nullable: true),
                    InterestLinksInterestLinkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestLists", x => x.InterestListId);
                    table.ForeignKey(
                        name: "FK_InterestLists_InterestLinks_InterestLinksInterestLinkId",
                        column: x => x.InterestLinksInterestLinkId,
                        principalTable: "InterestLinks",
                        principalColumn: "InterestLinkId");
                    table.ForeignKey(
                        name: "FK_InterestLists_Interests_InterestsInterestId",
                        column: x => x.InterestsInterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId");
                    table.ForeignKey(
                        name: "FK_InterestLists_Persons_PersonsPersonId",
                        column: x => x.PersonsPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId");
                });

            migrationBuilder.InsertData(
                table: "InterestLinks",
                columns: new[] { "InterestLinkId", "Description", "InterestLinkURL" },
                values: new object[,]
                {
                    { 1, "Photography", "https://en.wikipedia.org/wiki/Photography#:~:text=Photography%20is%20the%20art%2C%20application,material%20such%20as%20photographic%20film." },
                    { 2, "Photography", "https://www.smashingmagazine.com/2009/04/the-ultimate-photography-round-up/" },
                    { 3, "Gardening", "https://www.gardendesign.com/how-to/" },
                    { 4, "Painting", "https://www.pinterest.se/ideas/paintings/938071044570/" },
                    { 5, "Painting", "https://kleki.com/y" },
                    { 6, "Playing guitar", "https://yousician.com/blog/how-to-play-guitar" },
                    { 7, "Playing guitar", "https://guitarsonmain.com/blogs/news/the-benefits-of-playing-guitar-how-it-can-improve-your-life" },
                    { 8, "Cooking", "https://www.thepioneerwoman.com/food-cooking/" },
                    { 9, "Cooking", "https://www.alexmakesmeals.com/" },
                    { 10, "Reading", "https://www.reading.ac.uk/" }
                });

            migrationBuilder.InsertData(
                table: "InterestLists",
                columns: new[] { "InterestListId", "FK_InterestId", "FK_InterestLinkId", "FK_PersonId", "InterestLinksInterestLinkId", "InterestsInterestId", "PersonsPersonId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, null, null, null },
                    { 2, 1, 2, 2, null, null, null },
                    { 3, 3, 3, 3, null, null, null },
                    { 4, 4, null, 4, null, null, null },
                    { 5, 7, 7, 5, null, null, null },
                    { 6, 5, 5, 5, null, null, null },
                    { 7, 3, 3, 5, null, null, null },
                    { 8, 2, 8, 6, null, null, null },
                    { 9, 6, 10, 7, null, null, null },
                    { 10, 2, null, 8, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Capturing moments through the lens", "Photography" },
                    { 2, "Exploring flavors and creating delicious meals", "Cooking" },
                    { 3, "Growing plants and creating beautiful landscapes", "Gardening" },
                    { 4, "Exploring nature and enjoying scenic trails", "Hiking" },
                    { 5, "Expressing creativity through colors and brushstrokes", "Painting" },
                    { 6, "Immersing in captivating stories and expanding knowledge", "Reading" },
                    { 7, "Creating melodies and expressing emotions through music", "Playing guitar" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "john.smith@example.com", "John", "Smith", "123-456-7890" },
                    { 2, "emily.johnson@example.com", "Emily", "Johnson", "987-654-3210" },
                    { 3, "michael.davis@example.com", "Michael", "Davis", "555-123-4567" },
                    { 4, "sarah.thompson@example.com", "Sarah", "Thompson", "789-456-1230" },
                    { 5, "david.rodriguez@example.com", "David", "Rodriguez", "246-802-3579" },
                    { 6, "jennifer.martinez@example.com", "Jennifer", "Martinez", "345-678-9012" },
                    { 7, "christopher.wilson@example.com", "Christopher", "Wilson", "678-901-2345" },
                    { 8, "jessica.anderson@example.com", "Jessica", "Anderson", "987-654-3210" },
                    { 9, "matthew.thomas@example.com", "Matthew", "Thomas", "123-456-7890" },
                    { 10, "ashley.walker@example.com", "Ashley", "Walker", "456-789-0123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_InterestLinksInterestLinkId",
                table: "InterestLists",
                column: "InterestLinksInterestLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_InterestsInterestId",
                table: "InterestLists",
                column: "InterestsInterestId");

            migrationBuilder.CreateIndex(
                name: "IX_InterestLists_PersonsPersonId",
                table: "InterestLists",
                column: "PersonsPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterestLists");

            migrationBuilder.DropTable(
                name: "InterestLinks");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}

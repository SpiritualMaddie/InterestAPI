﻿// <auto-generated />
using System;
using InterestAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterestAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InterestAPI.Models.ConnectionTables.InterestList", b =>
                {
                    b.Property<int>("InterestListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestListId"));

                    b.Property<int>("FK_InterestId")
                        .HasColumnType("int");

                    b.Property<int?>("FK_InterestLinkId")
                        .HasColumnType("int");

                    b.Property<int>("FK_PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("InterestLinksInterestLinkId")
                        .HasColumnType("int");

                    b.Property<int?>("InterestsInterestId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonsPersonId")
                        .HasColumnType("int");

                    b.HasKey("InterestListId");

                    b.HasIndex("InterestLinksInterestLinkId");

                    b.HasIndex("InterestsInterestId");

                    b.HasIndex("PersonsPersonId");

                    b.ToTable("InterestLists");

                    b.HasData(
                        new
                        {
                            InterestListId = 1,
                            FK_InterestId = 1,
                            FK_InterestLinkId = 1,
                            FK_PersonId = 1
                        },
                        new
                        {
                            InterestListId = 2,
                            FK_InterestId = 1,
                            FK_InterestLinkId = 2,
                            FK_PersonId = 2
                        },
                        new
                        {
                            InterestListId = 3,
                            FK_InterestId = 3,
                            FK_InterestLinkId = 3,
                            FK_PersonId = 3
                        },
                        new
                        {
                            InterestListId = 4,
                            FK_InterestId = 4,
                            FK_PersonId = 4
                        },
                        new
                        {
                            InterestListId = 5,
                            FK_InterestId = 7,
                            FK_InterestLinkId = 7,
                            FK_PersonId = 5
                        },
                        new
                        {
                            InterestListId = 6,
                            FK_InterestId = 5,
                            FK_InterestLinkId = 5,
                            FK_PersonId = 5
                        },
                        new
                        {
                            InterestListId = 7,
                            FK_InterestId = 3,
                            FK_InterestLinkId = 3,
                            FK_PersonId = 5
                        },
                        new
                        {
                            InterestListId = 8,
                            FK_InterestId = 2,
                            FK_InterestLinkId = 8,
                            FK_PersonId = 6
                        },
                        new
                        {
                            InterestListId = 9,
                            FK_InterestId = 6,
                            FK_InterestLinkId = 10,
                            FK_PersonId = 7
                        },
                        new
                        {
                            InterestListId = 10,
                            FK_InterestId = 2,
                            FK_PersonId = 8
                        });
                });

            modelBuilder.Entity("InterestAPI.Models.Interest", b =>
                {
                    b.Property<int>("InterestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InterestId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestId = 1,
                            Description = "Capturing moments through the lens",
                            Title = "Photography"
                        },
                        new
                        {
                            InterestId = 2,
                            Description = "Exploring flavors and creating delicious meals",
                            Title = "Cooking"
                        },
                        new
                        {
                            InterestId = 3,
                            Description = "Growing plants and creating beautiful landscapes",
                            Title = "Gardening"
                        },
                        new
                        {
                            InterestId = 4,
                            Description = "Exploring nature and enjoying scenic trails",
                            Title = "Hiking"
                        },
                        new
                        {
                            InterestId = 5,
                            Description = "Expressing creativity through colors and brushstrokes",
                            Title = "Painting"
                        },
                        new
                        {
                            InterestId = 6,
                            Description = "Immersing in captivating stories and expanding knowledge",
                            Title = "Reading"
                        },
                        new
                        {
                            InterestId = 7,
                            Description = "Creating melodies and expressing emotions through music",
                            Title = "Playing guitar"
                        });
                });

            modelBuilder.Entity("InterestAPI.Models.InterestLink", b =>
                {
                    b.Property<int>("InterestLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestLinkId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("InterestLinkURL")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("InterestLinkId");

                    b.ToTable("InterestLinks");

                    b.HasData(
                        new
                        {
                            InterestLinkId = 1,
                            Description = "Photography",
                            InterestLinkURL = "https://en.wikipedia.org/wiki/Photography#:~:text=Photography%20is%20the%20art%2C%20application,material%20such%20as%20photographic%20film."
                        },
                        new
                        {
                            InterestLinkId = 2,
                            Description = "Photography",
                            InterestLinkURL = "https://www.smashingmagazine.com/2009/04/the-ultimate-photography-round-up/"
                        },
                        new
                        {
                            InterestLinkId = 3,
                            Description = "Gardening",
                            InterestLinkURL = "https://www.gardendesign.com/how-to/"
                        },
                        new
                        {
                            InterestLinkId = 4,
                            Description = "Painting",
                            InterestLinkURL = "https://www.pinterest.se/ideas/paintings/938071044570/"
                        },
                        new
                        {
                            InterestLinkId = 5,
                            Description = "Painting",
                            InterestLinkURL = "https://kleki.com/y"
                        },
                        new
                        {
                            InterestLinkId = 6,
                            Description = "Playing guitar",
                            InterestLinkURL = "https://yousician.com/blog/how-to-play-guitar"
                        },
                        new
                        {
                            InterestLinkId = 7,
                            Description = "Playing guitar",
                            InterestLinkURL = "https://guitarsonmain.com/blogs/news/the-benefits-of-playing-guitar-how-it-can-improve-your-life"
                        },
                        new
                        {
                            InterestLinkId = 8,
                            Description = "Cooking",
                            InterestLinkURL = "https://www.thepioneerwoman.com/food-cooking/"
                        },
                        new
                        {
                            InterestLinkId = 9,
                            Description = "Cooking",
                            InterestLinkURL = "https://www.alexmakesmeals.com/"
                        },
                        new
                        {
                            InterestLinkId = 10,
                            Description = "Reading",
                            InterestLinkURL = "https://www.reading.ac.uk/"
                        });
                });

            modelBuilder.Entity("InterestAPI.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            Email = "john.smith@example.com",
                            FirstName = "John",
                            LastName = "Smith",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            PersonId = 2,
                            Email = "emily.johnson@example.com",
                            FirstName = "Emily",
                            LastName = "Johnson",
                            Phone = "987-654-3210"
                        },
                        new
                        {
                            PersonId = 3,
                            Email = "michael.davis@example.com",
                            FirstName = "Michael",
                            LastName = "Davis",
                            Phone = "555-123-4567"
                        },
                        new
                        {
                            PersonId = 4,
                            Email = "sarah.thompson@example.com",
                            FirstName = "Sarah",
                            LastName = "Thompson",
                            Phone = "789-456-1230"
                        },
                        new
                        {
                            PersonId = 5,
                            Email = "david.rodriguez@example.com",
                            FirstName = "David",
                            LastName = "Rodriguez",
                            Phone = "246-802-3579"
                        },
                        new
                        {
                            PersonId = 6,
                            Email = "jennifer.martinez@example.com",
                            FirstName = "Jennifer",
                            LastName = "Martinez",
                            Phone = "345-678-9012"
                        },
                        new
                        {
                            PersonId = 7,
                            Email = "christopher.wilson@example.com",
                            FirstName = "Christopher",
                            LastName = "Wilson",
                            Phone = "678-901-2345"
                        },
                        new
                        {
                            PersonId = 8,
                            Email = "jessica.anderson@example.com",
                            FirstName = "Jessica",
                            LastName = "Anderson",
                            Phone = "987-654-3210"
                        },
                        new
                        {
                            PersonId = 9,
                            Email = "matthew.thomas@example.com",
                            FirstName = "Matthew",
                            LastName = "Thomas",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            PersonId = 10,
                            Email = "ashley.walker@example.com",
                            FirstName = "Ashley",
                            LastName = "Walker",
                            Phone = "456-789-0123"
                        });
                });

            modelBuilder.Entity("InterestAPI.Models.ConnectionTables.InterestList", b =>
                {
                    b.HasOne("InterestAPI.Models.InterestLink", "InterestLinks")
                        .WithMany("InterestLists")
                        .HasForeignKey("InterestLinksInterestLinkId");

                    b.HasOne("InterestAPI.Models.Interest", "Interests")
                        .WithMany("InterestLists")
                        .HasForeignKey("InterestsInterestId");

                    b.HasOne("InterestAPI.Models.Person", "Persons")
                        .WithMany("InterestLists")
                        .HasForeignKey("PersonsPersonId");

                    b.Navigation("InterestLinks");

                    b.Navigation("Interests");

                    b.Navigation("Persons");
                });

            modelBuilder.Entity("InterestAPI.Models.Interest", b =>
                {
                    b.Navigation("InterestLists");
                });

            modelBuilder.Entity("InterestAPI.Models.InterestLink", b =>
                {
                    b.Navigation("InterestLists");
                });

            modelBuilder.Entity("InterestAPI.Models.Person", b =>
                {
                    b.Navigation("InterestLists");
                });
#pragma warning restore 612, 618
        }
    }
}

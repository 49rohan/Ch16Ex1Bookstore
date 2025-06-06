﻿// <auto-generated />
using System;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ch16Ex1Bookstore.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20250420175220_FLNameRegistration")]
    partial class FLNameRegistration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bookstore.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            FirstName = "Michelle",
                            LastName = "Alexander"
                        },
                        new
                        {
                            AuthorId = 2,
                            FirstName = "Stephen E.",
                            LastName = "Ambrose"
                        },
                        new
                        {
                            AuthorId = 3,
                            FirstName = "Margaret",
                            LastName = "Atwood"
                        },
                        new
                        {
                            AuthorId = 4,
                            FirstName = "Jane",
                            LastName = "Austen"
                        },
                        new
                        {
                            AuthorId = 5,
                            FirstName = "James",
                            LastName = "Baldwin"
                        },
                        new
                        {
                            AuthorId = 6,
                            FirstName = "Emily",
                            LastName = "Bronte"
                        },
                        new
                        {
                            AuthorId = 7,
                            FirstName = "Agatha",
                            LastName = "Christie"
                        },
                        new
                        {
                            AuthorId = 8,
                            FirstName = "Ta-Nehisi",
                            LastName = "Coates"
                        },
                        new
                        {
                            AuthorId = 9,
                            FirstName = "Jared",
                            LastName = "Diamond"
                        },
                        new
                        {
                            AuthorId = 10,
                            FirstName = "Joan",
                            LastName = "Didion"
                        },
                        new
                        {
                            AuthorId = 11,
                            FirstName = "Daphne",
                            LastName = "Du Maurier"
                        },
                        new
                        {
                            AuthorId = 12,
                            FirstName = "Tina",
                            LastName = "Fey"
                        },
                        new
                        {
                            AuthorId = 13,
                            FirstName = "Roxane",
                            LastName = "Gay"
                        },
                        new
                        {
                            AuthorId = 14,
                            FirstName = "Dashiel",
                            LastName = "Hammett"
                        },
                        new
                        {
                            AuthorId = 15,
                            FirstName = "Frank",
                            LastName = "Herbert"
                        },
                        new
                        {
                            AuthorId = 16,
                            FirstName = "Aldous",
                            LastName = "Huxley"
                        },
                        new
                        {
                            AuthorId = 17,
                            FirstName = "Stieg",
                            LastName = "Larsson"
                        },
                        new
                        {
                            AuthorId = 18,
                            FirstName = "David",
                            LastName = "McCullough"
                        },
                        new
                        {
                            AuthorId = 19,
                            FirstName = "Toni",
                            LastName = "Morrison"
                        },
                        new
                        {
                            AuthorId = 20,
                            FirstName = "George",
                            LastName = "Orwell"
                        },
                        new
                        {
                            AuthorId = 21,
                            FirstName = "Mary",
                            LastName = "Shelley"
                        },
                        new
                        {
                            AuthorId = 22,
                            FirstName = "Sun",
                            LastName = "Tzu"
                        },
                        new
                        {
                            AuthorId = 23,
                            FirstName = "Augusten",
                            LastName = "Burroughs"
                        },
                        new
                        {
                            AuthorId = 25,
                            FirstName = "JK",
                            LastName = "Rowling"
                        },
                        new
                        {
                            AuthorId = 26,
                            FirstName = "Seth",
                            LastName = "Grahame-Smith"
                        });
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            GenreId = "history",
                            Price = 18.0,
                            Title = "1776"
                        },
                        new
                        {
                            BookId = 2,
                            GenreId = "scifi",
                            Price = 5.5,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            GenreId = "mystery",
                            Price = 4.5,
                            Title = "And Then There Were None"
                        },
                        new
                        {
                            BookId = 4,
                            GenreId = "history",
                            Price = 11.5,
                            Title = "Band of Brothers"
                        },
                        new
                        {
                            BookId = 5,
                            GenreId = "novel",
                            Price = 10.99,
                            Title = "Beloved"
                        },
                        new
                        {
                            BookId = 6,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "Between the World and Me"
                        },
                        new
                        {
                            BookId = 7,
                            GenreId = "memoir",
                            Price = 4.25,
                            Title = "Bossypants"
                        },
                        new
                        {
                            BookId = 8,
                            GenreId = "scifi",
                            Price = 16.25,
                            Title = "Brave New World"
                        },
                        new
                        {
                            BookId = 9,
                            GenreId = "history",
                            Price = 15.0,
                            Title = "D-Day"
                        },
                        new
                        {
                            BookId = 10,
                            GenreId = "memoir",
                            Price = 12.5,
                            Title = "Down and Out in Paris and London"
                        },
                        new
                        {
                            BookId = 11,
                            GenreId = "scifi",
                            Price = 8.75,
                            Title = "Dune"
                        },
                        new
                        {
                            BookId = 12,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Emma"
                        },
                        new
                        {
                            BookId = 13,
                            GenreId = "scifi",
                            Price = 6.5,
                            Title = "Frankenstein"
                        },
                        new
                        {
                            BookId = 14,
                            GenreId = "novel",
                            Price = 10.25,
                            Title = "Go Tell it on the Mountain"
                        },
                        new
                        {
                            BookId = 15,
                            GenreId = "history",
                            Price = 15.5,
                            Title = "Guns, Germs, and Steel"
                        },
                        new
                        {
                            BookId = 16,
                            GenreId = "memoir",
                            Price = 14.5,
                            Title = "Hunger"
                        },
                        new
                        {
                            BookId = 17,
                            GenreId = "mystery",
                            Price = 6.75,
                            Title = "Murder on the Orient Express"
                        },
                        new
                        {
                            BookId = 18,
                            GenreId = "novel",
                            Price = 8.5,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 19,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "Rebecca"
                        },
                        new
                        {
                            BookId = 20,
                            GenreId = "history",
                            Price = 5.75,
                            Title = "The Art of War"
                        },
                        new
                        {
                            BookId = 21,
                            GenreId = "mystery",
                            Price = 8.5,
                            Title = "The Girl with the Dragon Tattoo"
                        },
                        new
                        {
                            BookId = 22,
                            GenreId = "scifi",
                            Price = 12.5,
                            Title = "The Handmaid's Tale"
                        },
                        new
                        {
                            BookId = 23,
                            GenreId = "mystery",
                            Price = 10.99,
                            Title = "The Maltese Falcon"
                        },
                        new
                        {
                            BookId = 24,
                            GenreId = "history",
                            Price = 13.75,
                            Title = "The New Jim Crow"
                        },
                        new
                        {
                            BookId = 25,
                            GenreId = "memoir",
                            Price = 13.5,
                            Title = "The Year of Magical Thinking"
                        },
                        new
                        {
                            BookId = 26,
                            GenreId = "novel",
                            Price = 9.0,
                            Title = "Wuthering Heights"
                        },
                        new
                        {
                            BookId = 27,
                            GenreId = "memoir",
                            Price = 11.0,
                            Title = "Running With Scissors"
                        },
                        new
                        {
                            BookId = 28,
                            GenreId = "novel",
                            Price = 8.75,
                            Title = "Pride and Prejudice and Zombies"
                        },
                        new
                        {
                            BookId = 29,
                            GenreId = "novel",
                            Price = 9.75,
                            Title = "Harry Potter and the Sorcerer's Stone"
                        });
                });

            modelBuilder.Entity("Bookstore.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BookAuthors");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 18
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 20
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 7
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 19
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 8
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 12
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 16
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 2
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 20
                        },
                        new
                        {
                            BookId = 11,
                            AuthorId = 15
                        },
                        new
                        {
                            BookId = 12,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 13,
                            AuthorId = 21
                        },
                        new
                        {
                            BookId = 14,
                            AuthorId = 5
                        },
                        new
                        {
                            BookId = 15,
                            AuthorId = 9
                        },
                        new
                        {
                            BookId = 16,
                            AuthorId = 13
                        },
                        new
                        {
                            BookId = 17,
                            AuthorId = 7
                        },
                        new
                        {
                            BookId = 18,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 19,
                            AuthorId = 11
                        },
                        new
                        {
                            BookId = 20,
                            AuthorId = 22
                        },
                        new
                        {
                            BookId = 21,
                            AuthorId = 17
                        },
                        new
                        {
                            BookId = 22,
                            AuthorId = 3
                        },
                        new
                        {
                            BookId = 23,
                            AuthorId = 14
                        },
                        new
                        {
                            BookId = 24,
                            AuthorId = 1
                        },
                        new
                        {
                            BookId = 25,
                            AuthorId = 10
                        },
                        new
                        {
                            BookId = 26,
                            AuthorId = 6
                        },
                        new
                        {
                            BookId = 27,
                            AuthorId = 23
                        },
                        new
                        {
                            BookId = 28,
                            AuthorId = 4
                        },
                        new
                        {
                            BookId = 28,
                            AuthorId = 26
                        },
                        new
                        {
                            BookId = 29,
                            AuthorId = 25
                        });
                });

            modelBuilder.Entity("Bookstore.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "novel",
                            Name = "Novel"
                        },
                        new
                        {
                            GenreId = "memoir",
                            Name = "Memoir"
                        },
                        new
                        {
                            GenreId = "mystery",
                            Name = "Mystery"
                        },
                        new
                        {
                            GenreId = "scifi",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            GenreId = "history",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Bookstore.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.HasOne("Bookstore.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Bookstore.Models.BookAuthor", b =>
                {
                    b.HasOne("Bookstore.Models.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Models.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bookstore.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bookstore.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookstore.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bookstore.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bookstore.Models.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Bookstore.Models.Book", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("Bookstore.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

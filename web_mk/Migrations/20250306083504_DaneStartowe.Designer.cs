﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web_mk.DAL;

#nullable disable

namespace web_mk.Migrations
{
    [DbContext(typeof(FilmsContext))]
    [Migration("20250306083504_DaneStartowe")]
    partial class DaneStartowe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("web_mk.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Desc = "Filmy pełne dynamicznych scen i emocjonujących pościgów.",
                            Name = "Akcja"
                        },
                        new
                        {
                            CategoryId = 2,
                            Desc = "Filmy mające na celu rozbawić widza.",
                            Name = "Komedia"
                        },
                        new
                        {
                            CategoryId = 3,
                            Desc = "Filmy poruszające trudne i emocjonalne tematy.",
                            Name = "Dramat"
                        },
                        new
                        {
                            CategoryId = 4,
                            Desc = "Filmy mające na celu wywołać strach i napięcie.",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 5,
                            Desc = "Filmy osadzone w przyszłości lub świecie fantastycznym.",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 6,
                            Desc = "Filmy pełne magii, mitycznych stworzeń i niezwykłych przygód.",
                            Name = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 7,
                            Desc = "Filmy trzymające w napięciu z zaskakującymi zwrotami akcji.",
                            Name = "Thriller"
                        },
                        new
                        {
                            CategoryId = 8,
                            Desc = "Filmy animowane dla dzieci i dorosłych.",
                            Name = "Animacja"
                        },
                        new
                        {
                            CategoryId = 9,
                            Desc = "Filmy opowiadające o miłości i relacjach międzyludzkich.",
                            Name = "Romans"
                        },
                        new
                        {
                            CategoryId = 10,
                            Desc = "Filmy przedstawiające rzeczywiste wydarzenia i historie.",
                            Name = "Dokument"
                        });
                });

            modelBuilder.Entity("web_mk.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            CategoryId = 1,
                            Desc = "Postapokaliptyczna historia pełna akcji.",
                            Director = "George Miller",
                            Title = "Mad Max: Fury Road"
                        },
                        new
                        {
                            FilmId = 2,
                            CategoryId = 1,
                            Desc = "Profesjonalny zabójca wraca do akcji.",
                            Director = "Chad Stahelski",
                            Title = "John Wick"
                        },
                        new
                        {
                            FilmId = 3,
                            CategoryId = 2,
                            Desc = "Czterech przyjaciół budzi się po szalonej nocy.",
                            Director = "Todd Phillips",
                            Title = "The Hangover"
                        },
                        new
                        {
                            FilmId = 4,
                            CategoryId = 2,
                            Desc = "Dwaj nierozgarnięci przyjaciele wyruszają w podróż.",
                            Director = "Peter Farrelly",
                            Title = "Dumb and Dumber"
                        },
                        new
                        {
                            FilmId = 5,
                            CategoryId = 3,
                            Desc = "Historia niezwykłego życia Forresta Gumpa.",
                            Director = "Robert Zemeckis",
                            Title = "Forrest Gump"
                        },
                        new
                        {
                            FilmId = 6,
                            CategoryId = 3,
                            Desc = "Oskar Schindler ratuje Żydów podczas II wojny światowej.",
                            Director = "Steven Spielberg",
                            Title = "Schindler’s List"
                        },
                        new
                        {
                            FilmId = 7,
                            CategoryId = 4,
                            Desc = "Demonologowie badają nawiedzone domostwo.",
                            Director = "James Wan",
                            Title = "The Conjuring"
                        },
                        new
                        {
                            FilmId = 8,
                            CategoryId = 4,
                            Desc = "Grupa dzieci walczy z przerażającym klaunem.",
                            Director = "Andy Muschietti",
                            Title = "It"
                        },
                        new
                        {
                            FilmId = 9,
                            CategoryId = 5,
                            Desc = "Manipulowanie snami w celu osiągnięcia celu.",
                            Director = "Christopher Nolan",
                            Title = "Inception"
                        },
                        new
                        {
                            FilmId = 10,
                            CategoryId = 5,
                            Desc = "Podróż przez kosmos w poszukiwaniu nowego domu.",
                            Director = "Christopher Nolan",
                            Title = "Interstellar"
                        },
                        new
                        {
                            FilmId = 11,
                            CategoryId = 6,
                            Desc = "Epicka podróż przez Śródziemie.",
                            Director = "Peter Jackson",
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            FilmId = 12,
                            CategoryId = 6,
                            Desc = "Chłopiec odkrywa, że jest czarodziejem.",
                            Director = "Chris Columbus",
                            Title = "Harry Potter and the Sorcerer’s Stone"
                        },
                        new
                        {
                            FilmId = 13,
                            CategoryId = 7,
                            Desc = "Detektywi tropią seryjnego mordercę.",
                            Director = "David Fincher",
                            Title = "Se7en"
                        },
                        new
                        {
                            FilmId = 14,
                            CategoryId = 7,
                            Desc = "Zaginięcie żony ujawnia tajemnice małżeństwa.",
                            Director = "David Fincher",
                            Title = "Gone Girl"
                        },
                        new
                        {
                            FilmId = 15,
                            CategoryId = 8,
                            Desc = "Przygody zabawek, które ożywają.",
                            Director = "John Lasseter",
                            Title = "Toy Story"
                        },
                        new
                        {
                            FilmId = 16,
                            CategoryId = 8,
                            Desc = "Ogr ratuje księżniczkę i zakochuje się.",
                            Director = "Andrew Adamson",
                            Title = "Shrek"
                        },
                        new
                        {
                            FilmId = 17,
                            CategoryId = 9,
                            Desc = "Romantyczna historia dwojga zakochanych.",
                            Director = "Nick Cassavetes",
                            Title = "The Notebook"
                        },
                        new
                        {
                            FilmId = 18,
                            CategoryId = 9,
                            Desc = "Historia miłości Elizabeth Bennet i pana Darcy’ego.",
                            Director = "Joe Wright",
                            Title = "Pride & Prejudice"
                        },
                        new
                        {
                            FilmId = 19,
                            CategoryId = 10,
                            Desc = "Zapierające dech w piersiach obrazy natury.",
                            Director = "Alastair Fothergill",
                            Title = "Planet Earth"
                        },
                        new
                        {
                            FilmId = 20,
                            CategoryId = 10,
                            Desc = "Dokument o wpływie mediów społecznościowych.",
                            Director = "Jeff Orlowski",
                            Title = "The Social Dilemma"
                        });
                });

            modelBuilder.Entity("web_mk.Models.Film", b =>
                {
                    b.HasOne("web_mk.Models.Category", "Category")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("web_mk.Models.Category", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}

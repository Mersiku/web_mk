using Microsoft.EntityFrameworkCore;
using web_mk.Models;

namespace web_mk.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>
            {
                new Category { CategoryId = 1, Name = "Akcja", Desc = "Filmy pełne dynamicznych scen i emocjonujących pościgów." },
                new Category { CategoryId = 2, Name = "Komedia", Desc = "Filmy mające na celu rozbawić widza." },
                new Category { CategoryId = 3, Name = "Dramat", Desc = "Filmy poruszające trudne i emocjonalne tematy." },
                new Category { CategoryId = 4, Name = "Horror", Desc = "Filmy mające na celu wywołać strach i napięcie." },
                new Category { CategoryId = 5, Name = "Science Fiction", Desc = "Filmy osadzone w przyszłości lub świecie fantastycznym." },
                new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy pełne magii, mitycznych stworzeń i niezwykłych przygód." },
                new Category { CategoryId = 7, Name = "Thriller", Desc = "Filmy trzymające w napięciu z zaskakującymi zwrotami akcji." },
                new Category { CategoryId = 8, Name = "Animacja", Desc = "Filmy animowane dla dzieci i dorosłych." },
                new Category { CategoryId = 9, Name = "Romans", Desc = "Filmy opowiadające o miłości i relacjach międzyludzkich." },
                new Category { CategoryId = 10, Name = "Dokument", Desc = "Filmy przedstawiające rzeczywiste wydarzenia i historie." }
            };

            var films = new List<Film>
            {
                new Film {Poster="poster1.jpg", FilmId = 1, Title = "Mad Max: Fury Road", Director = "George Miller", Desc = "Postapokaliptyczna historia pełna akcji.", CategoryId = 1 },
                new Film {Poster="poster2.jpg", FilmId = 2, Title = "John Wick", Director = "Chad Stahelski", Desc = "Profesjonalny zabójca wraca do akcji.", CategoryId = 1 },
                new Film {Poster="poster3.jpg", FilmId = 3, Title = "The Hangover", Director = "Todd Phillips", Desc = "Czterech przyjaciół budzi się po szalonej nocy.", CategoryId = 2 },
                new Film {Poster="poster4.jpg", FilmId = 4, Title = "Dumb and Dumber", Director = "Peter Farrelly", Desc = "Dwaj nierozgarnięci przyjaciele wyruszają w podróż.", CategoryId = 2 },
                new Film {Poster="poster5.jpg", FilmId = 5, Title = "Forrest Gump", Director = "Robert Zemeckis", Desc = "Historia niezwykłego życia Forresta Gumpa.", CategoryId = 3 },
                new Film {Poster="poster6.jpg", FilmId = 6, Title = "Schindler’s List", Director = "Steven Spielberg", Desc = "Oskar Schindler ratuje Żydów podczas II wojny światowej.", CategoryId = 3 },
                new Film {Poster="poster7.jpg", FilmId = 7, Title = "The Conjuring", Director = "James Wan", Desc = "Demonologowie badają nawiedzone domostwo.", CategoryId = 4 },
                new Film {Poster="poster8.jpg", FilmId = 8, Title = "It", Director = "Andy Muschietti", Desc = "Grupa dzieci walczy z przerażającym klaunem.", CategoryId = 4 },
                new Film {Poster="poster9.jpg", FilmId = 9, Title = "Inception", Director = "Christopher Nolan", Desc = "Manipulowanie snami w celu osiągnięcia celu.", CategoryId = 5 },
                new Film {Poster="poster10.jpg", FilmId = 10, Title = "Interstellar", Director = "Christopher Nolan", Desc = "Podróż przez kosmos w poszukiwaniu nowego domu.", CategoryId = 5 },
                new Film {Poster="poster11.jpg", FilmId = 11, Title = "The Lord of the Rings", Director = "Peter Jackson", Desc = "Epicka podróż przez Śródziemie.", CategoryId = 6 },
                new Film {Poster="poster12.jpg", FilmId = 12, Title = "Harry Potter and the Sorcerer’s Stone", Director = "Chris Columbus", Desc = "Chłopiec odkrywa, że jest czarodziejem.", CategoryId = 6 },
                new Film {Poster="poster13.jpg", FilmId = 13, Title = "Se7en", Director = "David Fincher", Desc = "Detektywi tropią seryjnego mordercę.", CategoryId = 7 },
                new Film {Poster="poster14.jpg", FilmId = 14, Title = "Gone Girl", Director = "David Fincher", Desc = "Zaginięcie żony ujawnia tajemnice małżeństwa.", CategoryId = 7 },
                new Film {Poster="poster15.jpg", FilmId = 15, Title = "Toy Story", Director = "John Lasseter", Desc = "Przygody zabawek, które ożywają.", CategoryId = 8 },
                new Film {Poster="poster16.jpg", FilmId = 16, Title = "Shrek", Director = "Andrew Adamson", Desc = "Ogr ratuje księżniczkę i zakochuje się.", CategoryId = 8 },
                new Film {Poster="poster17.jpg", FilmId = 17, Title = "The Notebook", Director = "Nick Cassavetes", Desc = "Romantyczna historia dwojga zakochanych.", CategoryId = 9 },
                new Film {Poster="poster18.jpg", FilmId = 18, Title = "Pride & Prejudice", Director = "Joe Wright", Desc = "Historia miłości Elizabeth Bennet i pana Darcy’ego.", CategoryId = 9 },
                new Film {Poster="poster19.jpg", FilmId = 19, Title = "Planet Earth", Director = "Alastair Fothergill", Desc = "Zapierające dech w piersiach obrazy natury.", CategoryId = 10 },
                new Film {Poster="poster20.jpg", FilmId = 20, Title = "The Social Dilemma", Director = "Jeff Orlowski", Desc = "Dokument o wpływie mediów społecznościowych.", CategoryId = 10 }
            };                                

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);

        }
    }
}

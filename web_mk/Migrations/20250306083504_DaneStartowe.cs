using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_mk.Migrations
{
    public partial class DaneStartowe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy pełne dynamicznych scen i emocjonujących pościgów.", "Akcja" },
                    { 2, "Filmy mające na celu rozbawić widza.", "Komedia" },
                    { 3, "Filmy poruszające trudne i emocjonalne tematy.", "Dramat" },
                    { 4, "Filmy mające na celu wywołać strach i napięcie.", "Horror" },
                    { 5, "Filmy osadzone w przyszłości lub świecie fantastycznym.", "Science Fiction" },
                    { 6, "Filmy pełne magii, mitycznych stworzeń i niezwykłych przygód.", "Fantasy" },
                    { 7, "Filmy trzymające w napięciu z zaskakującymi zwrotami akcji.", "Thriller" },
                    { 8, "Filmy animowane dla dzieci i dorosłych.", "Animacja" },
                    { 9, "Filmy opowiadające o miłości i relacjach międzyludzkich.", "Romans" },
                    { 10, "Filmy przedstawiające rzeczywiste wydarzenia i historie.", "Dokument" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Postapokaliptyczna historia pełna akcji.", "George Miller", null, "Mad Max: Fury Road" },
                    { 2, 1, "Profesjonalny zabójca wraca do akcji.", "Chad Stahelski", null, "John Wick" },
                    { 3, 2, "Czterech przyjaciół budzi się po szalonej nocy.", "Todd Phillips", null, "The Hangover" },
                    { 4, 2, "Dwaj nierozgarnięci przyjaciele wyruszają w podróż.", "Peter Farrelly", null, "Dumb and Dumber" },
                    { 5, 3, "Historia niezwykłego życia Forresta Gumpa.", "Robert Zemeckis", null, "Forrest Gump" },
                    { 6, 3, "Oskar Schindler ratuje Żydów podczas II wojny światowej.", "Steven Spielberg", null, "Schindler’s List" },
                    { 7, 4, "Demonologowie badają nawiedzone domostwo.", "James Wan", null, "The Conjuring" },
                    { 8, 4, "Grupa dzieci walczy z przerażającym klaunem.", "Andy Muschietti", null, "It" },
                    { 9, 5, "Manipulowanie snami w celu osiągnięcia celu.", "Christopher Nolan", null, "Inception" },
                    { 10, 5, "Podróż przez kosmos w poszukiwaniu nowego domu.", "Christopher Nolan", null, "Interstellar" },
                    { 11, 6, "Epicka podróż przez Śródziemie.", "Peter Jackson", null, "The Lord of the Rings" },
                    { 12, 6, "Chłopiec odkrywa, że jest czarodziejem.", "Chris Columbus", null, "Harry Potter and the Sorcerer’s Stone" },
                    { 13, 7, "Detektywi tropią seryjnego mordercę.", "David Fincher", null, "Se7en" },
                    { 14, 7, "Zaginięcie żony ujawnia tajemnice małżeństwa.", "David Fincher", null, "Gone Girl" },
                    { 15, 8, "Przygody zabawek, które ożywają.", "John Lasseter", null, "Toy Story" },
                    { 16, 8, "Ogr ratuje księżniczkę i zakochuje się.", "Andrew Adamson", null, "Shrek" },
                    { 17, 9, "Romantyczna historia dwojga zakochanych.", "Nick Cassavetes", null, "The Notebook" },
                    { 18, 9, "Historia miłości Elizabeth Bennet i pana Darcy’ego.", "Joe Wright", null, "Pride & Prejudice" },
                    { 19, 10, "Zapierające dech w piersiach obrazy natury.", "Alastair Fothergill", null, "Planet Earth" },
                    { 20, 10, "Dokument o wpływie mediów społecznościowych.", "Jeff Orlowski", null, "The Social Dilemma" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}

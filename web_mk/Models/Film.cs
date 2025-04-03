using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace web_mk.Models
{
    public class Film
    {
        public int FilmId { get; set; }

        [Required(ErrorMessage ="Podaj tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(600, ErrorMessage = "Przekroczono limit znakow")]
        public string Desc { get; set; }

        public decimal? Price { get; set; } //? <- nie bedzie polem not null, tekstowe domyslnie dozwolone puste, liczbowe odwrotnie
        public string Poster { get; set; } // grafiki

        /* opcja 1 */
        public int CategoryId { get; set; }

        /* opcja 2 */
        //public int CategoryCategoryId { get; set; }

        /* opcja 3 */
        //[ForeignKey("Category")]
        //public int KategoriaId { get; set; }

        public Category Category { get; set; }
    }
}

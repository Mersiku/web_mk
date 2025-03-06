using System.ComponentModel.DataAnnotations;

namespace web_mk.Models
{
    public class Category
    {
        //[Key]
        //public int KategoriaId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(600, ErrorMessage = "Przekroczono limit znakow")]
        public string Desc { get; set; }

        public ICollection<Film> Films  { get; set; }
    }
}

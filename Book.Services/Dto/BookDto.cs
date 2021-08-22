using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Book.Services.Dto
{
    public class BookDto
    {
        public int Id { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre del libro es requerido")]
        [MaxLength(300, ErrorMessage = "El nombre no puede superar los 300 caracteres")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El genero del libro es requerido")]
        [MaxLength(300, ErrorMessage = "El genero no puede superar los 50 caracteres")]
        public string Gender { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int Pages { get; set; }
        public int AuthorId { get; set; }
    }
}

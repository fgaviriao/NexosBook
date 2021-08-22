using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Services.Dto
{
    public class AuthorDto
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El nombre del autoro es requerido")]
        [MaxLength(300, ErrorMessage = "El nombre no puede superar los 300 caracteres")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime Birthday { get; set; }
        
        public string City { get; set; }
        
        [Required(AllowEmptyStrings =false,ErrorMessage ="El correo es requerido")]
        [EmailAddress]
        [MaxLength(300,ErrorMessage = "El correo no puede superar los 300 caracteres")]
        public string Email { get; set; }
    }
}

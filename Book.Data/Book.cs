using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Book.Data
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public int Year { get; set; }
        public int AuthorId { get; set; }
        public Author Autor { get; set; }
    }
}

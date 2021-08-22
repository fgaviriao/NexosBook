using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(300)]
        public string Email { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}

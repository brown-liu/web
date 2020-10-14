using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test.Model
{
    public class Book
    {   [Required]
        public String name { get; set; }
        [Key]
        public int Id { get; set; }

        public int star { get; set; }
        [Required]
        public String Author { get; set; }
    }

}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLab.Models
{
    public class Author
    {
        [Key]
        public int Author_Id { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        [MaxLength(75)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string? Adress { get; set; }
        public int? Age { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();
    }
}

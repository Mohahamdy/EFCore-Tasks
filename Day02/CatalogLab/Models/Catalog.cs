using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLab.Models
{
    public class Catalog
    {
        [Key]
        public int Catalog_Id { get; set; }

        [MaxLength(50)]
        public string name { get; set; }

        public string? description { get; set; }

        public virtual List<News> news { get; set; } = new List<News>();
    }

}

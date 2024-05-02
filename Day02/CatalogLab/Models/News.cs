using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogLab.Models
{
    public class News
    {
        [Key]
        public int News_Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Bref { get; set; }
        public DateOnly? Date { get; set; }
        public TimeOnly? Time { get; set; }

        [ForeignKey("Auth")]
        public int AuthId { get; set; }
        public virtual Author Auth { get; set; }

        [ForeignKey("Cat")]
        public int CatId { get; set; }
        public virtual Catalog Cat {  get; set; }

    }
}

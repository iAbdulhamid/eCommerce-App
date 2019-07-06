using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.API.Models
{
    [Table("category")]
    public class category
    {
        [Required]
        [Key]
        public int ID {get; set;}
        public string Name {get; set;}
        public string ParentCategory {get; set;}

        [ForeignKey("parentCategory")]
        public int parentCategory_ID { get; set; }
        public virtual parentCategory parentCategory { get; set; }
        public virtual ICollection<product> products { get; set; }
    }
}
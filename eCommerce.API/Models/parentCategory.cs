using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eCommerce.API.Models
{
    [Table("parentCategory")]
    public class parentCategory
    {
        [Required]
        [Key]
        public int ID {get; set;}
        public string Name {get; set;}
        public string Description { get; set; }

        public virtual ICollection<category> categories { get; set; }


    }
}
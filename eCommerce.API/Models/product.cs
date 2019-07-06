using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.API.Models
{
    [Table("product")]
    public class product
    {
        [Required]
        [Key]
        public int ID {get; set;}
        public string Name {get; set;}
        public int Price {get; set;}
        public int AvailableQuantity {get; set;}
        public int QuantityLimit {get; set;}
        public string Image {get; set;}
        public string Description {get; set;}

        [ForeignKey("category")]
        public int category_ID { get; set; }
        public virtual category category { get; set; }
    }
}
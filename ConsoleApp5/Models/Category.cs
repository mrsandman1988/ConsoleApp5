using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ConsoleApp5.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("MainCategory")]
        public int? MainCategoryId { get; set; } // FK, artaqin banali
        public virtual MainCategory? MainCategory { get; set; } // navigation property

        public virtual ICollection<Product> Products { get; set; }
    }
}

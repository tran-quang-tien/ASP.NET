using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tqtlession8.Models
{  
   
    public class tqtCategory
    {
        [Key]
        public int tqtCategoryid { get; set; }
        public string tqtCategoryname { get; set; }
        
        public virtual ICollection<tqtBook> TqtBooks { get; set; } 
    }
}
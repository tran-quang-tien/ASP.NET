using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tqtlession8.Models
{
    public class tqtBook
    {   
       [Key]
        public int tqtBookid { get; set; }

        public string tqttittle { get; set; }

        public string tqtauthor { get; set; }

        public int tqtyear { get; set; }

        public string tqtpublisher {get;set;}

        public string tqtpicture { get; set; }

        public int tqtCategoryid { get; set; }

        public virtual tqtCategory TqtCategory { get; set; }
    }
}
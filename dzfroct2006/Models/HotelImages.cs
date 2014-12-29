using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dzfroct2006.Models
{
    public class HotelImages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdImage { get; set; }
        public String PathImage { get; set; }
        public String Name { get; set; }
        //path
         //   name
          //  description

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dzfroct2006.Models
{
    public class HotelRooms
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double RoomID { get; set; }

        public String RoomType { get; set; }

        public String Description { get; set; }

        public int NbPersonnes { get; set; }

        public int NbRooms { get; set; }

        public Hotels Hotel { get; set; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dzfroct2006.Models
{
    public class Hotels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long HotelID { get; set; }
        
        [Required]
        public String Name {get; set;}
        
        [Required]
        public String Description {get; set;}

        public String PhoneNumber1 {get; set;}
        public String PhoneNumber2 { get; set; }
        public String PhoneNumber3 { get; set; }

        public String FaxNumber1 {get; set;}
        public String FaxNumber2 { get; set; }
        public String FaxNumber3 { get; set; }

        public String Email1 { get; set; }
        public String Email2 { get; set; }

        public String Address { get; set; }
        public String Town { get; set; }
        public String Wilaya { get; set; }
        public String AddressDescription { get; set; }

        public HotelOwners Owner { get; set; }

        public List<HotelRooms> Rooms { get; set; }

        //HotelFeatures
        public List<HotelImages> HotelImages { get; set; }
     }
}
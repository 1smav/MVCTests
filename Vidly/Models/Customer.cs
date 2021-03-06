﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Customer
    {
        public int  Id{ get; set; }
        // Not nullable
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedtoNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}
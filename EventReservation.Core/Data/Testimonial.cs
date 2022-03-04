﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventReservation.Core.Data
{
    public class Testimonial
    {
        public int Testimonialid { get; set; }
        public string Personalname { get; set; }
        public string Imagepath { get; set; }
        public string Feedback { get; set; }
        public string Status { get; set; }
       
        public int? Websiteid { get; set; }
        [ForeignKey("Websiteid")]
        public virtual Website Website { get; set; }
    }
}

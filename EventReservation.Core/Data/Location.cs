﻿using System;
using System.Collections.Generic;

namespace EventReservation.Core.Data
{
    public  class Location
    {
     
        public int Locationid { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual ICollection<Hall> HallF { get; set; }
    }
}

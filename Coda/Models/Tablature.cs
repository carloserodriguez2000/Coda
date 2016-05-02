﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coda.Models
{
    public class Tablature
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public int TotalRaters { get; set; }
        public double AverageRating { get; set; }

    }
}
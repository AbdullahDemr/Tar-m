﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.Models
{
    public class AnnouncementModel
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Imageurl { get; set; }
        public string Description { get; set; }
        public string MinDescription { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}

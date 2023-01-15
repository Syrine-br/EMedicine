﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EMedicineBE.Models
{
    public class Medicine
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public string Imageurl { get; set; }
        public int Status { get; set; }

        public string Type { get; set; }


    }
}

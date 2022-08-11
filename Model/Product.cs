﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhoneX.Model
{
    public class Product
    {
        public string name { get; set; }

        public int id { get; set; }

        public double price { get; set; }

        public string description { get; set; }

        public int quantity { get; set; }

        public int category_id { get; set; }
    }
}

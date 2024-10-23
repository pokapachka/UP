using System;
using System.Collections.Generic;
using System.Text;

namespace OsokinUP.Models
{
    public class Partners_products
    {
        public int Id { get; set; }
        public int Product { get; set; }
        public int Partner { get; set; }
        public int Count_product { get; set; }
        public DateTime Date_sell { get; set; }
    }
}

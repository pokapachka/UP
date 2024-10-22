using System;
using System.Collections.Generic;
using System.Text;

namespace OsokinUP.Models
{
    public class Materials
    {
        public int id { get; set; }
        public string Material_type { get; set; }
        public string Name { get; set; }
        public float Defect_rate { get; set; }
        public int Supplier { get; set; }
        public int Quantity_in_packaging { get; set; }
        public int Unit_of_measurement { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OsokinUP.Models
{
    public class Materials
    {
        public int Id { get; set; }
        public string Material_type { get; set; }
        public string Name { get; set; }
        public float Defect_rate { get; set; }
        public int Supplier { get; set; }
        public int Quantity_in_packaging { get; set; }
        public string Unit_of_measurement { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int Quantity_in_stock { get; set; }
        public float Minimum_allowed_quantity { get; set; }
        public string Change_history { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OsokinUP.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Article { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Minimum_cost_for_a_partner { get; set; }
        public float Package_size { get; set; }
        public float Weight_without_packaging { get; set; }
        public float Weight_with_packaging { get; set; }
        public string Quality_certificate { get; set; }
        public int Standard_number { get; set; }
        public string History_of_changes { get; set; }
        public DateTime Production_time { get; set; }
        public float Cost_price { get; set; }
        public int Workshop_number { get; set; }
        public int Number_of_people_in_production { get; set; }
        public string Necessary_materials { get; set; }
    }
}

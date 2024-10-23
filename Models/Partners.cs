using System;
using System.Collections.Generic;
using System.Text;

namespace OsokinUP.Models
{
    public class Partners
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name_partner { get; set; }
        public string Legal_adress { get; set; }
        public int INN { get; set; }
        public string Name_director { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public int Rating { get; set; }
        public string Places_sale { get; set; }
        public string Implementation_history { get; set; }
    }
}

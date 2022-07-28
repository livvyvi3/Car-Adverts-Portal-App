using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Adverts_Portal.Models
{
    public class AdvertModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Year { get; set; }

        public string Color { get; set; }

        public string Condition { get; set; }

        public decimal Price { get; set; }

        public string Images { get; set; }

        public int Doors { get; set; }

        public string Status { get; set; }
    }
}
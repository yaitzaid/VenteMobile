using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Manufacturier
    {
        public int ManufacturierId { get; set; }
        public string ManufacturierMarque { get; set; }
        public string ManufacturierSiteWeb { get; set; }
        public string ManufacturierOrigine { get; set; }
        public  ICollection<Telephone> Telephones { get; set; } = new HashSet<Telephone>();
        public  ICollection<VendeurManufacturier> VendeursManufacturiers { get; set; } = new HashSet<VendeurManufacturier>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Vendeur
    {
        public int VendeurId { get; set; }
        public string VendeurNom { get; set; }
        public string VendeurAddress { get; set; }
        public string VendeurNoTel { get; set; }
       
        public  ICollection<TelephoneVendeur> TelephonesVendeurs { get; set; } = new HashSet<TelephoneVendeur>();
        public  ICollection<VendeurManufacturier> VendeursManufacturiers { get; set; } = new HashSet<VendeurManufacturier>();
    }
}

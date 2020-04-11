using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Telephone
    {
        public int TelephoneId { get; set; }
        public string TelephoneModel { get; set; }
        public int TelephoneCout { get; set; }
        public string TelephoneCouleur { get; set; }
        public int ManufacturierId { get; set; }
        public  Manufacturier Manufacturier { get; set; }
        public  ICollection<TelephoneVendeur> TelephonesVendeurs { get; set; } = new HashSet<TelephoneVendeur>();
        public  ICollection<Critique> Critiques { get; set; } = new HashSet<Critique>();
    }
}

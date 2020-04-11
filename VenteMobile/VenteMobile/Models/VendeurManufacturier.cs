using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class VendeurManufacturier
    {
        //[Key]
        //public int Id { get; set; }
        public int VendeurId { get; set; }
        public Vendeur Vendeur { get; set; }
        public int ManufacturierId { get; set; }
        public Manufacturier Manufacturier { get; set; }
    }
}

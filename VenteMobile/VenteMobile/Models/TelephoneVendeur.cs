using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VenteMobile.Models
{
    public class TelephoneVendeur
    {
      
        public int VendeurId { get; set; }
        public Vendeur Vendeur { get; set; }
        public int TelephoneId { get; set; }
        public Telephone Telephone { get; set; }  
    }
}

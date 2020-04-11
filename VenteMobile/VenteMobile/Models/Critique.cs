using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Critique
    {
        public int CritiqueId { get; set; }
        public string CritiqueText { get; set; }
        public int CritiqueEtoiles { get; set; }
        public string CritiqueNom { get; set; }
        public int TelephoneId { get; set; }
        public Telephone Telephone { get; set; }
    }
}

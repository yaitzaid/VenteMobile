using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Vendeur
        : IDisposable
    {
        private bool _disposed = false;
        public int VendeurId { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+[a-zA-Z]$", ErrorMessage = "Seul les alphabets avec des espaces sont autorisés")]
        [Display(Name = "Nom")]
        public string VendeurNom { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string VendeurAddress { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("[(][0-9]{3}[)][ ][0-9]{3}[-][0-9]{4}", ErrorMessage = "Entrer un numero de telephone valide (###) ###-####")]
        [Display(Name = "NoTel")]
        public string VendeurNoTel { get; set; }
        public ICollection<TelephoneVendeur> TelephonesVendeurs { get; set; } = new HashSet<TelephoneVendeur>();
        public ICollection<VendeurManufacturier> VendeursManufacturiers { get; set; } = new HashSet<VendeurManufacturier>();
        ~Vendeur()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {

                }
            }
            _disposed = true;
        }
    }
}

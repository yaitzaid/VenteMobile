using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VenteMobile.Models
{
    public class Manufacturier
       : IDisposable
    {
        private bool _disposed = false;
        public int ManufacturierId { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+[a-zA-Z]$", ErrorMessage = "Seul les alphabets avec des espaces sont autorisés")]
        [Display(Name = "Marque")]
        public string ManufacturierMarque { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [RegularExpression(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", ErrorMessage = "Seul les url sont autorisés")]
        [Display(Name = "SiteWeb")]
        public string ManufacturierSiteWeb { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+[a-zA-Z]$", ErrorMessage = "Seul les alphabets avec des espaces sont autorisés")]
        [Display(Name = "Siège social")]
        public string ManufacturierOrigine { get; set; }
        public ICollection<Telephone> Telephones { get; set; } = new HashSet<Telephone>();
        public ICollection<VendeurManufacturier> VendeursManufacturiers { get; set; } = new HashSet<VendeurManufacturier>();
        ~Manufacturier()
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

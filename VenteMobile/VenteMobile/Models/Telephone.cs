using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VenteMobile.Models
{
    public class Telephone
       : IDisposable
    {
        private bool _disposed = false;
        public int TelephoneId { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [Display(Name = "Modèle")]
        public string TelephoneModel { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})?$", ErrorMessage = "Seul les chiffre entier ou 2 chiffre apres le 1 est autorisé")]
        [Display(Name = "Prix")]
        public double TelephoneCout { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+[a-zA-Z]$", ErrorMessage = "Seul les alphabets avec des espaces sont autorisés")]
        [Display(Name = "Couleur")]
        public string TelephoneCouleur { get; set; }
        public int ManufacturierId { get; set; }
        public Manufacturier Manufacturier { get; set; }
        public ICollection<TelephoneVendeur> TelephonesVendeurs { get; set; } = new HashSet<TelephoneVendeur>();
        public ICollection<Critique> Critiques { get; set; } = new HashSet<Critique>();
        ~Telephone()
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

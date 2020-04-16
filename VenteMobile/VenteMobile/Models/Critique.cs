using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VenteMobile.Models
{
    public class Critique
         : IDisposable
    {
        private bool _disposed = false;
        public int CritiqueId { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Doit etre 3 et 200 caractere")]
        [Display(Name = "Commentaire")]
        public string CritiqueText { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [Range(1, 6)]
        [Display(Name = "Etoiles")]
        public int CritiqueEtoiles { get; set; }
        [Required(ErrorMessage = "Le champs est obligatoire")]
        [DataType(DataType.Text)]
        [RegularExpression("[a-zA-Z][a-zA-Z ]+[a-zA-Z]$", ErrorMessage = "Seul les alphabets avec des espaces sont autorisés")]
        [Display(Name = "Client")]
        public string CritiqueNom { get; set; }
        public int TelephoneId { get; set; }
        public Telephone Telephone { get; set; }
        ~Critique()
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

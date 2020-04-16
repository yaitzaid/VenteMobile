using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VenteMobile.Models
{
    public class TelephoneVendeur
       : IDisposable
    {
        private bool _disposed = false;
        public int VendeurId { get; set; }
        public Vendeur Vendeur { get; set; }
        public int TelephoneId { get; set; }
        public Telephone Telephone { get; set; }
        ~TelephoneVendeur()
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

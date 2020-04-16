using System;

namespace VenteMobile.Models
{
    public class VendeurManufacturier
   : IDisposable
    {
        private bool _disposed = false;
        //[Key]
        //public int Id { get; set; }
        public int VendeurId { get; set; }
        public Vendeur Vendeur { get; set; }
        public int ManufacturierId { get; set; }
        public Manufacturier Manufacturier { get; set; }
        ~VendeurManufacturier()
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

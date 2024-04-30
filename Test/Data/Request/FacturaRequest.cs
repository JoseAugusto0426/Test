namespace Test.Data.Request
{
    public class FacturaRequest
    {
        public int Id { get; set; }
        public int ContactoId { get; set; }
        public virtual ICollection<FacturaDetalleRequest> Detalles { get; set; }
            = new List<FacturaDetalleRequest>();
        public decimal SubTotal =>
            Detalles != null ?
            Detalles.Sum(d => d.SubTotal)
            :
            0;
    }

}

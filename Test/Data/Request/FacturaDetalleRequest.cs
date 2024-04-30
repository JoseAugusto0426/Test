namespace Test.Data.Request
{
    public class FacturaDetalleRequest
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string? Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal => Cantidad * Precio;
    }

}

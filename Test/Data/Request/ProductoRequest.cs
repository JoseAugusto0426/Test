namespace Test.Data.Request
{
    public class ProductoRequest
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Stock { get; set; }
        public string color { get; set; } = null!;
        public decimal PrecioCompra { get; set; }
        public decimal Precio { get; set; }

    }
}

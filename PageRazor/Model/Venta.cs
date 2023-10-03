namespace PageRazor.Model
{
    public class Venta : IEquatable<Venta>
    {
        public int Id { get; set; }
        public string? Fecha { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Vendedor { get; set; }

        public bool Equals(Venta? other)
        {
            return Fecha == other.Fecha;
        }
    }
}

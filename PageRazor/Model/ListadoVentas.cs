namespace PageRazor.Model
{

    public interface IListadoVentas
    {
        public IEnumerable<Venta> ObtenerTodos();
        public Venta? ObtenerUno(int id);
        public void Crear(Venta venta);
        public void Editar(Venta venta);
        public void Borrar(Venta venta);

    }
}

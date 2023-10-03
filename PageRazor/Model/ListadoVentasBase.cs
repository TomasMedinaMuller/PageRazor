namespace PageRazor.Model
{
    public class ListadoVentasBase : IListadoVentas
    {
        private List<Venta> Datos = new List<Venta>() 
        {
            new Venta()
            {
                Id = 1,
                Cantidad = 10,
                Nombre= "Samsung S21",
                Descripcion = "Celular Samsumg 128gb",
                Precio = 700,
                Fecha = "2022-08-10",
                Vendedor = "Samsung"

            }
        };
        public void Borrar(Venta venta)
        {
            //Elimina todos los elementos que sean igual al objeto venta y almacena el rersultado en un lista. 
            Datos = Datos.Where((v) => !v.Equals(venta)).ToList();
        }

        public void Crear(Venta venta)
        {
            Datos.Add(venta);
        }

        public void Editar(Venta nueva)
        {
            // cada dato previa se compara con nueva, si existe se reemplaza, de lo contrario no. 
            Datos = Datos.Select((previa) =>
            {
                if (previa.Id == nueva.Id)
                    return nueva;
                else
                    return previa;
            }).ToList();
        }

        public IEnumerable<Venta> ObtenerTodos()
        {
            // retorna todos los datos
            return Datos;
        }

        public Venta? ObtenerUno(int id)
        {
            // busca en datos la venta que sea igual al id. 
            return Datos.Where((venta) => venta.Id == id).First(); 
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PageRazor.Model;

namespace PageRazor.Pages
{
    
    public class NuevoModel : PageModel
    {
        // llama a la Interface
        public IListadoVentas Listado { get; set; }

        // la instanceo en la page Nuevo
        public NuevoModel(IListadoVentas listado) 
        {
            Listado = listado;
        }
        public void OnGet()
        {
        }

        // Metodo para crear el nuevo articulo
        public void OnPost() 
        {
            Listado.Crear(new Venta()
            {
                Id = Convert.ToInt32(Request.Form["Id"]),
                Cantidad = Convert.ToInt32(Request.Form["Cantidad"]),
                Descripcion = Request.Form["Descripcion"],
                Fecha = Request.Form["Fecha"],
                Nombre = Request.Form["Nombre"],
                Precio = Convert.ToInt32(Request.Form["Precio"]),
                Vendedor = Request.Form["Vendedor"],
            });
            // para que vuelva a la page anterior 
            Response.Redirect("/");
        }
        
    }
}

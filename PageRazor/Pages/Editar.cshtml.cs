using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PageRazor.Model;

namespace PageRazor.Pages
{
  
    public class EditarModel : PageModel
    {
        private IListadoVentas Listado; 
        public Venta? Venta { get; set; }

        public EditarModel (IListadoVentas listado)
        {
            Listado = listado;
        }

        public void OnGet()
        {
            int id = Convert.ToInt32(Request.Query["Id"]);
            Venta = Listado.ObtenerUno(id);
        }
        public void OnPost()
        {
            Listado.Editar(new Venta()
            {
                Id = Convert.ToInt32(Request.Form["Id"]),
                Cantidad = Convert.ToInt32(Request.Form["Cantidad"]),
                Descripcion = Request.Form["Descripcion"],
                Fecha = Request.Form["Fecha"],
                Nombre = Request.Form["Nombre"],
                Precio = Convert.ToDouble(Request.Form["Precio"]),
                Vendedor = Request.Form["Vendedor"]
            });
            Response.Redirect("/");
        }
    }
}

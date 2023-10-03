using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PageRazor.Model;

namespace PageRazor.Pages
{
    public class DetalleModel : PageModel
    {
        public Venta? Venta { get; set; }
        private IListadoVentas _listado;

        public DetalleModel (IListadoVentas listado)
        {
            _listado = listado;
        }

        public void OnGet()
        {
            int id = Convert.ToInt32(Request.Query["Id"]);
            Venta = _listado.ObtenerUno(id);
        }
    }
}

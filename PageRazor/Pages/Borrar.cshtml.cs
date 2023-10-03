using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PageRazor.Model;

namespace PageRazor.Pages
{
    public class BorrarModel : PageModel
    {
        private IListadoVentas _listado;
        public BorrarModel(IListadoVentas listado)
        {
            _listado = listado;
        }
        public void OnGet()
        {
            int id = Convert.ToInt32(Request.Query["Id"]);

            Venta? v = _listado.ObtenerUno(id);

            _listado.Borrar(v);

            Response.Redirect("/");
        }
    }
}

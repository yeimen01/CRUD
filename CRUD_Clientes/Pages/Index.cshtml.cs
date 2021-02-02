using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_Clientes.Data;
using CRUD_Clientes.Model;

namespace CRUD_Clientes.Pages
{
    public class IndexModel : PageModel
    {
        public IClientes ClientesService;

        public IList<ClsClientes> Cliente { get; set; }

        [BindProperty(SupportsGet = true)]
        public string NombreCliente { get; set; }

        [TempData]
        public string MensajeBorrado { get; set; }

        public IndexModel( IClientes iclientes)
        {
            ClientesService = iclientes;
        }

        public void OnGet()
        {
            this.Cliente = ClientesService.ObtenerClientesPorNombre(NombreCliente);
        }
    }
}

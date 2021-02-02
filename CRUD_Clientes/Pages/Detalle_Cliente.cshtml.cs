using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_Clientes.Data;
using CRUD_Clientes.Model;


namespace CRUD_Clientes.Pages
{
    public class Detalle_ClienteModel : PageModel
    {
        private readonly IClientes service;
        public ClsClientes cCliente { get; set; }

        [TempData]
        public string Mensaje { get; set; }

        public Detalle_ClienteModel(IClientes service)
        {
            this.service = service;
        }

        public IActionResult OnGet(int Id)
        {
            cCliente = service.ObtenerClientePorId(Id);

            if (cCliente == null)
            {
                return RedirectToPage("RegistroNoEncontrado");
            }
            else
            {
                return Page();
            }
        }
    }
}
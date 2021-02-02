using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_Clientes.Data;
using CRUD_Clientes.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Clientes.Pages
{
    public class Borrar_ClienteModel : PageModel
    {
        private readonly IClientes service;
        public ClsClientes cCliente { get; set; }
        public IEnumerable<SelectListItem> Sexo { get; set; }

        public Borrar_ClienteModel(IClientes service)
        {
            this.service = service;
        }

        public void OnGet(int Id)
        {
            this.cCliente = service.ObtenerClientePorId(Id);
        }

        public ActionResult OnPost(int Id)
        {
            var cliente = service.BorrarCliente(Id);
            service.GuardarCambios();
            TempData["MensajeBorrado"] = $"Se ha borrado el cliente {cliente.StrNombre + cliente.StrApellido}";
            return RedirectToPage("/Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRUD_Clientes.Data;
using CRUD_Clientes.Model;


namespace CRUD_Clientes.Pages
{
    public class Editar_ClienteModel : PageModel
    {
        private readonly IClientes service;

        private readonly IHtmlHelper helper;

        [BindProperty(SupportsGet = true)]

        public ClsClientes cCliente { get; set; }

        public IEnumerable<SelectListItem> Sexo { get; set; }

        public Editar_ClienteModel(IClientes service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }

        public void OnGet(int? Id)
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            if (Id.HasValue)
            {
                cCliente = service.ObtenerClientePorId(Id.Value);
            }
            else
            {
                cCliente = new ClsClientes();
            }
        }

        public ActionResult OnPost()
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            if (ModelState.IsValid)
            {
                if (cCliente.IntIdCliente != 0)
                {
                    cCliente = service.ActualizarCliente(cCliente);
                    TempData["Mensaje"] = "Registro Actualizado de manera correcta";
                }
                service.GuardarCambios();
                return RedirectToPage("/Detalle_Cliente", new { Id = cCliente.IntIdCliente });
            }
            return Page();
        }
    }
}
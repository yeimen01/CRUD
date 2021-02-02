using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_Clientes.Model;
using CRUD_Clientes.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Clientes.Pages
{
    public class Crear_ClienteModel : PageModel
    {
        //Declarando el servicio
        private readonly IClientes service;

        //Declarando el Helper para poder utilizar el comboBox
        private readonly IHtmlHelper helper;

        //Declarando que use tanto Get al igual que usa Post
        [BindProperty(SupportsGet = true)]

        //Instanciando la clase
        public ClsClientes Cliente { get; set; }

        //Listado del sexo
        public IEnumerable<SelectListItem> Sexo { get; set; }

        public Crear_ClienteModel(IClientes service, IHtmlHelper helper)
        {
            this.service = service;
            this.helper = helper;
        }

        public void OnGet()
        {
            Sexo = helper.GetEnumSelectList<Sexo>();
            Cliente = new ClsClientes();
        }

        public ActionResult OnPost()
        {
            Sexo = helper.GetEnumSelectList<Sexo>();

            if (ModelState.IsValid)
            {
                if (Cliente.IntIdCliente == 0)
                {
                    Cliente = service.CrearCliente(Cliente);
                    TempData["Mensaje"] = "Registro Creado de manera correcta";
                }

                service.GuardarCambios();

                return RedirectToPage("./Index", new { Id = Cliente.IntIdCliente });
            }
            return Page();
        }
    }
}


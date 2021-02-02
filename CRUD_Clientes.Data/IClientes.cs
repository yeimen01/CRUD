using System;
using System.Collections.Generic;
using System.Text;
using CRUD_Clientes.Model;

namespace CRUD_Clientes.Data
{
    public interface IClientes
    {
        IList<ClsClientes> ObtenerClientesPorNombre(string NombreCliente);

        public ClsClientes ObtenerClientePorId(int Id);

        ClsClientes ActualizarCliente(ClsClientes ClienteActualizado);

        ClsClientes CrearCliente(ClsClientes Cliente);

        ClsClientes BorrarCliente(int Id);

        int GuardarCambios();

    }
}

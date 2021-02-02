using CRUD_Clientes.Model;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_Clientes.Data
{
    public class Clsclientes_EF : IClientes
    { 
        private Clientes_Context cDB;

    public Clsclientes_EF(Clientes_Context cDB)
    {
        this.cDB = cDB;
    }

        //Creando Cliente
        public ClsClientes CrearCliente(ClsClientes cCliente)
        {
            cDB.Clientes.Add(cCliente);
            return cCliente;
        }


        //Metodo para actualizar
        public ClsClientes ActualizarCliente(ClsClientes cCliente_Actualizado)
        {
            var Cliente_Updated = cDB.Clientes.SingleOrDefault(cliente => cliente.IntIdCliente == cCliente_Actualizado.IntIdCliente);

            //Actualizando el Cliente
            Cliente_Updated.IntIdCliente = cCliente_Actualizado.IntIdCliente;
            Cliente_Updated.StrNombre = cCliente_Actualizado.StrNombre;
            Cliente_Updated.StrApellido = cCliente_Actualizado.StrApellido;
            Cliente_Updated.DtFechaNacimineto = cCliente_Actualizado.DtFechaNacimineto;
            Cliente_Updated.ESexo = cCliente_Actualizado.ESexo;
            Cliente_Updated.StrDirección = cCliente_Actualizado.StrDirección;

            return Cliente_Updated;

        }


        //Metodo para borrar
        public ClsClientes BorrarCliente(int Id)
        {
            var Cliente = cDB.Clientes.Single(c => c.IntIdCliente == Id);
            cDB.Clientes.Remove(Cliente);

            return Cliente;
        }


        //Buscando el cliente por su Id
        public ClsClientes ObtenerClientePorId(int Id)
        {
            return cDB.Clientes.SingleOrDefault(c => c.IntIdCliente == Id);
        }


        //Buscando Cliente por Nombre
        public IList<ClsClientes> ObtenerClientesPorNombre(string NombreCliente)
        {
            if (!string.IsNullOrEmpty(NombreCliente))
            {
                NombreCliente = NombreCliente.ToLower();
            }

            return cDB.Clientes.Where(e => string.IsNullOrEmpty(NombreCliente) || e.StrNombre.ToLower().Contains(NombreCliente)).OrderBy(e => e.IntIdCliente).ToList();
        }

        //Guardando Cambios
        public int GuardarCambios()
        {
            return cDB.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CRUD_Clientes.Model;

namespace CRUD_Clientes.Data
{
    public class Clientes_Context : DbContext
    {

        public Clientes_Context(DbContextOptions<Clientes_Context> options) : base(options)
        { 
        
        }

        public DbSet<ClsClientes> Clientes { get; set; }
    }
}

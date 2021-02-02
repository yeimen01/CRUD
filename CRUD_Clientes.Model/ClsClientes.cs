using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Clientes.Model
{   
    public class ClsClientes
    {
        [Key]
        public int  IntIdCliente { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [MinLength(4, ErrorMessage = "Debe introducir como minimo 4 carácteres en la Nombre")]
        [MaxLength(20, ErrorMessage = "Debe introducir como maximo 50 carácteres en el Nombre")]
        public string StrNombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es requerido")]
        public string StrApellido { get; set; }

        public DateTime DtFechaNacimineto { get; set; }
        public int IntEdad
        {
            get
            {
                int Anos = DateTime.Today.Year - DtFechaNacimineto.Year;
                if (DateTime.Today < DtFechaNacimineto.AddYears(Anos))
                {
                    Anos--;
                }
                return Anos;
            }
        }
        public Sexo ESexo { get; set; }

        [Required(ErrorMessage = "El campo Dirección es requerido")]
        public string StrDirección { get; set; }
    }

}

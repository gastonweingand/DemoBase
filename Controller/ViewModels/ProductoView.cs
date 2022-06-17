using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ViewModels
{
    public class ProductoView
    {
        [Browsable(false)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Código es requerido")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido")]
        [StringLength(maximumLength: 20, MinimumLength =5 , ErrorMessage = "La descripción tiene entre 5 y 20 caracteres")]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string DescripcionLarga
        {
            get
            {
                return $"{Codigo}: {Descripcion}";
            }
        }


        //[Browsable(false)] //Atributo que no se muestra como propiedad en objetos de ventanas...
        //[Required(ErrorMessage = "Nombre es requerido")]
        //[StringLength(maximumLength: 8, MinimumLength = 6, ErrorMessage = "El dni no contiene el formato necesario: 6-8")]
    }
}

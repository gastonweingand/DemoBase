using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.ViewModels
{
    public class ProductoView 
    {
        public Guid Id { get; set; }

        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

    }
}

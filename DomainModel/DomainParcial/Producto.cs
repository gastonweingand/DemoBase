using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DomainParcial
{
    public class Producto
    {
        public Guid Id { get; set; }

        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DomainParcial
{
    public class DetalleMovimiento
    {
        public Producto Producto { get; set; }

        public decimal Cantidad { get; set; }
    }
}

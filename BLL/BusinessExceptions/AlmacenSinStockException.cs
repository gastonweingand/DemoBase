using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessExceptions
{
    public class AlmacenSinStockException : Exception
    {
        public Producto Producto { get; set; }
        public AlmacenSinStockException(Producto producto) : base("El depósito no tiene stock suficiente...")
        {
            Producto = producto;
        }
    }
}

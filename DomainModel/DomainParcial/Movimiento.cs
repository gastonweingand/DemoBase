using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DomainParcial
{
    public class Movimiento
    {
        public Guid Id { get; set; }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public Deposito Origen { get; set; }

        public Almacen Destino { get; set; }

        public Usuario Usuario { get => default; set { } }

        public List<DetalleMovimiento> DetalleMovimientos { get; set; }


        public Movimiento()
        {
            DetalleMovimientos = new List<DetalleMovimiento>(); 
        }
    }
}



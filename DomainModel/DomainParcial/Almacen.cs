using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.DomainParcial
{
    public class Almacen
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Localidad { get; set; }

        public string Provincia { get; set; }

        public List<Stock> Stock { get; set; }

        public Almacen()
        {
            Stock = new List<Stock>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DomainModel.Security.Composite
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public string Password { get; set; }

        public List<Component> Permisos { get; set; }

        public Usuario()
        {
            Permisos = new List<Component>();
        }

        /// <summary>
        /// Retornar las patentes únicas de acuerdo a mi modelo
        /// (Para el armado del menú)
        /// </summary>
        /// <returns></returns>
        public List<Patente> GetPatentesAll()
        {
            return null;
        }

    }
}

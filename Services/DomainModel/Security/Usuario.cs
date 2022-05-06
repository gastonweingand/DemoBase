using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DomainModel.Security
{
    internal class Usuario
    {
        public string Nombre { get; set; }

        public string Password { get; set; }

        public List<Familia> Familias { get; set; }

        public List<Patente> Patentes { get; set; }


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

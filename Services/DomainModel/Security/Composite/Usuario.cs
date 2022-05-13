using Services.Services;
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

        public string HashPassword
        {
            get
            {
                return CryptographyService.HashPassword(this.Password);
            }
        }

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
            List<Patente> patentesDistinct = new List<Patente>();

            RecorrerComposite(patentesDistinct, Permisos, "-");

            return patentesDistinct;
        }

        private static void RecorrerComposite(List<Patente> patentes, List<Component> components, string tab)
        {
            foreach (var item in components)
            {
                if (item.ChildrenCount() == 0)
                {
                    //Estoy ante un elemento de tipo Patente
                    Patente patente1 = item as Patente;
                    Console.WriteLine($"{tab} Patente: {patente1.FormName}");

                    if(!patentes.Exists(o => o.FormName == patente1.FormName))
                        patentes.Add(patente1);

                    //bool existe = false;

                    //foreach (var item2 in patentes)
                    //{
                    //    if(item2.FormName == patente1.FormName)
                    //    {
                    //        existe = true;
                    //        break;
                    //    }
                    //}

                    //if(!existe)
                    //    patentes.Add(patente1);
                }
                else
                {
                    Familia familia = item as Familia;
                    Console.WriteLine($"{tab} Familia: {familia.Nombre}");
                    RecorrerComposite(patentes, familia.GetChildrens(), tab + "-");
                }
            }
        }

    }
}

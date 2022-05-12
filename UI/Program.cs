using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Services;
using System.Threading;
using System.Globalization;
using Services.Services.Extensions;
using BLL.BusinessExceptions;
using Services.DomainModel.Security.Composite;
using BLL.Services;

namespace UI
{
    class Program
    {
        private static void RecorrerComposite(List<Component> components, string tab)
        {
            foreach (var item in components)
            {
                if (item.ChildrenCount() == 0)
                {
                    //Estoy ante un elemento de tipo Patente
                    Patente patente1 = item as Patente;
                    Console.WriteLine($"{tab} Patente: {patente1.FormName}");
                }
                else
                {
                    Familia familia = item as Familia;
                    Console.WriteLine($"{tab} Familia: {familia.Nombre}");
                    RecorrerComposite(familia.GetChildrens(), tab + "-");
                }
            }
        }


        static void Main(string[] args)
        {
            //Usuario usuario = new Usuario();

            //usuario.Permisos.Add();

            //List<Patente> patentes = usuario.GetPatentesAll();

            Patente patente = new Patente() { FormName = "frmGestionVentas", MenuItemName = "Gestión de ventas" };
            Patente patente2 = new Patente() { FormName = "frmGestionCompras", MenuItemName = "Gestión de compras" };
            Patente patente3 = new Patente() { FormName = "frmReportesGenerales", MenuItemName = "Reportes general" };
            Patente patente4 = new Patente() { FormName = "frmPerfilUsuario", MenuItemName = "Perfil" };
            Patente patente5 = new Patente() { FormName = "frmPrincipal", MenuItemName = "Principal" };

            Familia familiaGestionVentas = new Familia(patente, "Rol Gestión Ventas");
            Familia familiaGestionCompras = new Familia(patente2, "Rol Gestión Compras");
            familiaGestionCompras.Add(patente3);

            Familia administrador = new Familia(familiaGestionVentas, "Rol Administrador");
            administrador.Add(familiaGestionCompras);
            administrador.Add(patente4);
            administrador.Add(patente5);

            Usuario usuario = new Usuario();
            usuario.Permisos.Add(administrador);
            usuario.Permisos.Add(patente5);

            Console.WriteLine("Listado de permisos de mi usuario:");

            List<Patente> patentesUser = usuario.GetPatentesAll();

            foreach (var item in patentesUser)
            {
                Console.WriteLine($"Patente: {item.FormName}");
            }

            //UsoDeFactory();

            try
            {
                Customer customer = new Customer()
                {
                    Doc = "312222",
                    DateBirth = DateTime.Now.AddYears(-20),
                    FirstName = "Marcelo",
                    LastName = "Di Deo",
                };

                BLL.Services.CustomerService.Current.Add(customer);
            }
            catch(ClienteMayorEdadException ex)
            {
                Console.WriteLine($"Exception del negocio: {ex.Message}, Helplink: {ex.HelpLink}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}, StackTrace: {ex.StackTrace}");
                
            }
          

            //BLL.Services.CustomerService.Current.Add("312222", DateTime.Now.AddYears(-20), "Marcelo", "Di Deo");


            ServicioTraduccion();

            UsoDeFactory();

            //DemoParametrizacion demo = new DemoParametrizacion();
            //Console.WriteLine(demo.ConnString);
            //Console.WriteLine(demo.Path);



            //DemoSingleton obj1 = DemoSingleton.Current;
            //DemoSingleton obj2 = DemoSingleton.Current;            

            //if (obj1 == obj2)
            //    Console.WriteLine("Los obj son iguales (Puntero)");
            //else
            //    Console.WriteLine("Los obj son diferentes (Puntero)");


            //Console.WriteLine(DemoParametrizacion.GetInstancia().ConnString);
            //Console.WriteLine(DemoParametrizacion.GetInstancia().Path);

            //DemoParametrizacion obj6 = DemoParametrizacion.GetInstancia();

            //obj6.Path = "Lo que quiera";

            //DemoParametrizacion obj2 = DemoParametrizacion.GetInstancia();

            ////obj1.Path = "Cualquier cosa";

            //if (obj1 == obj2)            
            //    Console.WriteLine("Los obj son iguales (Puntero)");
            //else
            //    Console.WriteLine("Los obj son diferentes (Puntero)");
        }

        private static void ServicioTraduccion()
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);

            string testWord = "hola".Translate();

            Console.WriteLine($"Palabra traducida {testWord}");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            testWord = "hola".Translate();

            Console.WriteLine($"Palabra traducida {testWord}");
        }

        private static void UsoDeFactory()
        {
            Customer customerGet = CustomerService.Current.SelectOne(Guid.Parse("7285B85B-7771-EA11-8198-98AF655C0AE3"));
            //Customer clienteGet = DAL.Factories.CustomerFactory.Current.GetFactory("sqlserver").SelectOne(Guid.Parse("7285B85B-7771-EA11-8198-98AF655C0AE3"));

        }
    }
}

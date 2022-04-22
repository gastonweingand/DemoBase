using DAL;
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

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);

            string testWord = "hola".Translate();

            Console.WriteLine($"Palabra traducida {testWord}");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            testWord = "hola".Translate();

            Console.WriteLine($"Palabra traducida {testWord}");


            Customer clienteGet = DAL.Factories.CustomerFactory.Current.GetFactory("sqlserver").SelectOne(Guid.Parse("7285B85B-7771-EA11-8198-98AF655C0AE3"));

            DAL.Factories.CustomerFactory.Current.GetFactory("sqlserver").SelectOne(Guid.Empty);
            DAL.Factories.CustomerFactory.Current.GetFactory("plaintext").SelectOne(Guid.Empty);




            //DemoParametrizacion demo = new DemoParametrizacion();
            //Console.WriteLine(demo.ConnString);
            //Console.WriteLine(demo.Path);



            DemoSingleton obj1 = DemoSingleton.Current;
            DemoSingleton obj2 = DemoSingleton.Current;            

            if (obj1 == obj2)
                Console.WriteLine("Los obj son iguales (Puntero)");
            else
                Console.WriteLine("Los obj son diferentes (Puntero)");


            Console.WriteLine(DemoParametrizacion.GetInstancia().ConnString);
            Console.WriteLine(DemoParametrizacion.GetInstancia().Path);

            DemoParametrizacion obj6 = DemoParametrizacion.GetInstancia();

            //obj6.Path = "Lo que quiera";

            //DemoParametrizacion obj2 = DemoParametrizacion.GetInstancia();

            ////obj1.Path = "Cualquier cosa";

            //if (obj1 == obj2)            
            //    Console.WriteLine("Los obj son iguales (Puntero)");
            //else
            //    Console.WriteLine("Los obj son diferentes (Puntero)");
        }
    }
}

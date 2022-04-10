using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
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

using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Clase como abstracción de la parametrización del sistema...
    /// </summary>
    internal class DemoParametrizacion
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Proveedor] (Nombre,Codigo) VALUES (@Nombre,@Codigo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Proveedor] SET (Nombre,Codigo) WHERE IdProveedor = @IdProveedor";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Proveedor] WHERE IdProveedor = @IdProveedor";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdProveedor, Nombre,Codigo FROM [dbo].[Proveedor] WHERE IdProveedor = @IdProveedor";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdProveedor, Nombre,Codigo FROM [dbo].[Proveedor]";
        }
        #endregion

        /// <summary>
        /// Propiedad para trabajar la conect principal de la App
        /// </summary>
        public string ConnString { get; private set; }

        public string Path { get; private set; }

        private static DemoParametrizacion instancia;

        private static object locker = new object();//Sirve para fines de bloqueo...

        /// <summary>
        /// Método que retorna la instancia única de la clase...
        /// </summary>
        /// <returns>Tipo DemoParametrizacion</returns>
        public static DemoParametrizacion GetInstancia()
        {
            //Validamos cómo está el ciclo de vida de la variable instancia
            //Hilo Nro 1
            //Hilo Nro 2
            //if (instancia == null)//Hilo 1, Hilo 2
            //    //Hilo2, Hilo 1
            //    instancia = new DemoParametrizacion();

            //Hilo1, Hilo2
            if (instancia == null)
            {
                //Hilo1, Hilo2,Hilo 100...
                lock (locker)
                {
                    //Hilo1
                    if (instancia == null)
                    {
                        instancia = new DemoParametrizacion();
                    }
                }
            }

            return instancia;
        }

        private DemoParametrizacion()
        {            
            ConnString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;

            Path = ConfigurationManager.AppSettings["PathLog"];

            //SqlDataReader dr = SqlHelper.ExecuteReader("Select * from customer", System.Data.CommandType.Text);

            //while(dr.Read())
            //{
            //    Console.WriteLine(dr.GetString(2));
            //}
        }
    }
}

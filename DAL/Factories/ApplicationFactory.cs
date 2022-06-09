using DAL.Contracts;
using DAL.Contracts.UnitOfWork;
using DomainModel;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{
    public static class ApplicationFactory
    {
        private static string backendDS = ConfigurationManager.AppSettings["BackendDS"];

        /// <summary>
        /// Actualizo todos los repositorios a patrón UnitOfWork ya que todos los repositorios estarán contenidos
        /// dentro de un contexto transaccional
        /// </summary>
        public static IUnitOfWork UnitOfWork { get; private set; }

        static ApplicationFactory()
        {
            if (backendDS == "sqlserver")
            {
                UnitOfWork = new Implementations.SqlServer.UnitOfWork.UnitOfWorkSqlServer();
            }
            else if (backendDS == "plaintext")
            {
                //CustomerRepository = new DAL.Implementations.PlainText.CustomerRepository();
            }
            else if (backendDS == "memory")
            {
                //AlmacenRepository = new DAL.Implementations.Memory.AlmacenRepository();
                //MovimientoRepository = new DAL.Implementations.Memory.MovimientoRepository();
            }
        }
    }
}

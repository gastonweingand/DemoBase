using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{

    public sealed class FamiliaPatenteRepository : IJoinRepository<Familia, Patente>
    {
        #region Singleton
        private readonly static FamiliaPatenteRepository _instance = new FamiliaPatenteRepository();

        public static FamiliaPatenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaPatenteRepository()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Add(Familia obj, List<Patente> hijos)
        {
            throw new NotImplementedException();
        }

        public void Delete(Familia obj)
        {
            throw new NotImplementedException();
        }

        public void GetChildren(Familia obj)
        {
            //3) Buscar en SP Familia_Patente_Select y retornar id de patentes relacionados
            //4) Iterar sobre esos ids -> LLamar al Adaptador y cargar las patentes...
            throw new NotImplementedException();
        }
    }
}

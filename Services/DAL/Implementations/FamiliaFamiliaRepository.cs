using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{

    public sealed class FamiliaFamiliaRepository : IJoinRepository<Familia, Familia>
    {
        #region Singleton
        private readonly static FamiliaFamiliaRepository _instance = new FamiliaFamiliaRepository();

        public static FamiliaFamiliaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaFamiliaRepository()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Add(Familia obj, List<Familia> hijos)
        {
            throw new NotImplementedException();
        }

        public void Delete(Familia obj)
        {
            throw new NotImplementedException();
        }

        public void GetChildren(Familia obj)
        {
            //1) Buscar en SP Familia_Familia_Select y retornar id de familias relacionados
            //2) Iterar sobre esos ids -> LLamar al Adaptador y cargar las familias...

            throw new NotImplementedException();
        }
    }
}

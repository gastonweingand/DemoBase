using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations.Adapter
{

    public sealed class FamiliaAdapter : IAdapter<Familia>
    {
        #region Singleton
        private readonly static FamiliaAdapter _instance = new FamiliaAdapter();

        public static FamiliaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaAdapter()
        {
            //Implement here the initialization code
        }
        #endregion
        public Familia Adapt(object[] values)
        {
            //Hidratar el objeto familia -> Nivel 1
            Familia familia = new Familia()
            {
                IdComponent = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString()
            };


            //Nivel 2 de hidratación...
            FamiliaFamiliaRepository.Current.GetChildren(familia);
            FamiliaPatenteRepository.Current.GetChildren(familia);
           
            return familia;
        }
    }
}

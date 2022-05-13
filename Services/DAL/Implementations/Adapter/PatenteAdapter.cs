using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations.Adapter
{

    public sealed class PatenteAdapter : IAdapter<Patente>
    {
        #region Singleton
        private readonly static PatenteAdapter _instance = new PatenteAdapter();

        public static PatenteAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteAdapter()
        {
            //Implement here the initialization code
        }
        #endregion

        public Patente Adapt(object[] values)
        {
            //Hidratar el objeto patente
            Patente patente = new Patente()
            {
                IdComponent = Guid.Parse(values[0].ToString()),
                MenuItemName = values[1].ToString(),
                FormName = values[2].ToString()
            };
            return patente;
        }
    }

}

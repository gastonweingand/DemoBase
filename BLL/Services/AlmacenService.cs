using BLL.Contracts;
using DAL.Factories;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{

    public sealed class AlmacenService : IGenericBusinessService<Almacen>
    {
        #region Singleton
        private readonly static AlmacenService _instance = new AlmacenService();

        public static AlmacenService Current
        {
            get
            {
                return _instance;
            }
        }

        private AlmacenService()
        {
            //Implement here the initialization code
        }
        #endregion

        public void Add(Almacen obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Almacen obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Almacen> SelectAll()
        {
            return ApplicationFactory.AlmacenRepository.SelectAll();
        }

        public Almacen SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

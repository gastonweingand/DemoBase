using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DAL.Contracts;
using Services.DomainModel.Security.Composite;

namespace Services.DAL.Implementations
{
    internal sealed class UsuarioRepository : IGenericRepository<Usuario>
    {
        #region Singleton
        private readonly static UsuarioRepository _instance = new UsuarioRepository();

        public static UsuarioRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioRepository()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Add(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Usuario SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}

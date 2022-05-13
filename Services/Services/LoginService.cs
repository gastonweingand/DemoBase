using Services.DomainModel.Security.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public static class LoginService
    {

        public static bool Login(Usuario usuario)
        {
            return false;
        }
        public static Patente SelectOnePatente(Guid id)
        {
            return DAL.Implementations.PatenteRepository.Current.SelectOne(id);
        }

        public static Usuario SelectOneUsuario(Guid id)
        {
            return DAL.Implementations.UsuarioRepository.Current.SelectOne(id);
        }

        public static IEnumerable<Patente> SelectAllPatentes()
        {
            return DAL.Implementations.PatenteRepository.Current.SelectAll();
        }

        public static Familia SelectOneFamilia(Guid id)
        {
            return DAL.Implementations.FamiliaRepository.Current.SelectOne(id);
        }

    }
}

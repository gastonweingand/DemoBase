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

    public sealed class ProductoService : IGenericBusinessService<Producto>
    {
        #region Singleton
        private readonly static ProductoService _instance = new ProductoService();

        public static ProductoService Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoService()
        {
            //Implement here the initialization code
        }


        #endregion

        public void Add(Producto obj)
        {
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                context.Repositories.ProductoRepository.Add(obj);
                context.SaveChanges();
            }
        }

        public void Update(Producto obj)
        {
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                context.Repositories.ProductoRepository.Update(obj);
                context.SaveChanges();
            }            
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> SelectAll()
        {
            List<Producto> lstProductos = new List<Producto>();
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                lstProductos = context.Repositories.ProductoRepository.SelectAll().ToList();
            }
            return lstProductos;
        }

        public Producto SelectOne(Guid id)
        {
            ///Crea todos los repositorios juntos
            ///
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                return context.Repositories.ProductoRepository.SelectOne(id);
            }
        }
        public Producto SelectAll(String sFilter)
        {
            ///Crea todos los repositorios juntos
            ///
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                //IEnumerable<Producto> productos;
                //return context.Repositories.ProductoRepository.SelectAll();// .SelectAll( " id= "); // (sFilter);
                //return productos;
                return null; 
            }
        }
    }

}

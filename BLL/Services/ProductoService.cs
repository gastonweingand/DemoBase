﻿using BLL.Contracts;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Producto SelectOne(Guid id)
        {
            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                return context.Repositories.ProductoRepository.SelectOne(id);
            }
        }
    }

}

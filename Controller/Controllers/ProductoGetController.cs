using Controller.Contracts;
using Controller.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services;
using DomainModel.DomainParcial;
using Controller.ViewModels.Helpers;
using Controllers.Validators;

namespace Controller.Controllers
{
    public class ProductoGetController : IGetController <ProductoView>
    {
        [ViewValidator]

        /*
        public List<ProductoView> GetAll(string filterExpression)
        {
            var ProductosDTO = ProductoService.Current.SelectAll(filterExpression).ToList();
            var ProductosView = MapperHelper.GetMapper().Map<List<Producto>, List<ProductoView>>(ProductosDTO);

            return ProductosView;
        }
        */


        public IEnumerable<ProductoView> GetAll()
        {
            var ProductosDTO = ProductoService.Current.SelectAll().ToList();
            var ProductosView = MapperHelper.GetMapper().Map<List<Producto>, List<ProductoView>>(ProductosDTO);

            return ProductosView;
        }

        public ProductoView GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        //private Producto MapperProducto(ProductoView obj)
        //{
        //    return new Producto() { Codigo = obj.Codigo, Descripcion = obj.Descripcion };
        //}

    }
}

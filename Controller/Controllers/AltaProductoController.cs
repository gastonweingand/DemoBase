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
using Controller.Validators;

namespace Controller.Controllers
{
    public class AltaProductoController : ICreateController<ProductoView>
    {
        [ViewValidator]
        public void Add(ProductoView obj)
        {
            var productoDTO = MapperHelper.GetMapper().Map<ProductoView, Producto>(obj);
            ProductoService.Current.Add(productoDTO);
        }

        //private Producto MapperProducto(ProductoView obj)
        //{
        //    return new Producto() { Codigo = obj.Codigo, Descripcion = obj.Descripcion };
        //}

    }
}

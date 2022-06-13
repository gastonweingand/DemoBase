using DAL.Contracts;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer.Adapter
{

    public sealed class ProductoAdapter : IAdapter<Producto>
    {
        #region Singleton
        private readonly static ProductoAdapter _instance = new ProductoAdapter();

        public static ProductoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoAdapter()
        {
            //Implement here the initialization code
        }
        #endregion

        public Producto Adapt(object[] values)
        {
            Producto customer = new Producto()
            {

                Id = Guid.Parse(values[0].ToString()),
                Codigo = values[1].ToString(),
                Descripcion = values[2].ToString(),
                Precio = decimal.Parse(values[3].ToString()),
            };
            return customer;
        }
    }

}

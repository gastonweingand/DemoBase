using BLL.BusinessExceptions;
using DAL.Factories;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MovimientoService
    {
        #region Singleton
        private readonly static MovimientoService _instance = new MovimientoService();

        public static MovimientoService Current
        {
            get
            {
                return _instance;
            }
        }

        private MovimientoService()
        {
            //Implement here the initialization code
        }
        #endregion

        public void TransferirStock(Deposito deposito, Almacen almacen, List<DetalleMovimiento> detalle)
        {
            try
            {
                //Listado de productos con cantidades que desean moverse entre A->B
                foreach (var item in detalle)
                {
                    decimal stockEnDeposito = deposito.Stock.FirstOrDefault(o => o.Producto.Id == item.Producto.Id).Cantidad;
                    if (stockEnDeposito < item.Cantidad)
                    {
                        throw new AlmacenSinStockException(item.Producto);
                    }
                }

                TxTransferencia(deposito, almacen, detalle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private static void TxTransferencia(Deposito deposito, Almacen almacen, List<DetalleMovimiento> detalle)
        {
            //COMIENZA LA TX
            //Acá tendríamos que hacer un begin Tx

            using (var context = ApplicationFactory.UnitOfWork.Create())
            {
                //1) Restar del Depósitos las cantidad-productos solicitadas
                foreach (var item in detalle)
                {
                    deposito.Stock.FirstOrDefault(o => o.Producto.Id == item.Producto.Id).Cantidad -= item.Cantidad;
                }

                context.Repositories.AlmacenRepository.Update(deposito);

                //2) Incrementar en el destino la cantidad-productos solicitadas
                foreach (var item in detalle)
                {
                    almacen.Stock.FirstOrDefault(o => o.Producto.Id == item.Producto.Id).Cantidad += item.Cantidad;
                }
                context.Repositories.AlmacenRepository.Update(almacen);

                //3) Registro la operación en mi entidad Movimientos...
                Movimiento movimiento = new Movimiento();
                movimiento.Origen = deposito;
                movimiento.Destino = almacen;
                movimiento.Fecha = DateTime.Now;
                movimiento.DetalleMovimientos = detalle;
                movimiento.Usuario = new Usuario() { Nombre = "Lucas" };
                context.Repositories.MovimientoRepository.Add(movimiento);

                //Persisto todo en la base de datos
                context.SaveChanges();
            }
        }

        public IEnumerable<Movimiento> GetAll()
        {
            return ApplicationFactory.UnitOfWork.Create().Repositories.MovimientoRepository.SelectAll();
        }
    }
}

using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STOCK INICIAL");
            List<Almacen> listadoDBAlmacenes = MostrarStock();
            

            Tienda carrefourBoulogne = (Tienda)listadoDBAlmacenes[0];
            Deposito depoPacheco = (Deposito)listadoDBAlmacenes[2];

            Producto productoTelevisor = listadoDBAlmacenes[0].Stock[0].Producto;

            List<DetalleMovimiento> detalleStockMovilizar = new List<DetalleMovimiento>();
            detalleStockMovilizar.Add(new DetalleMovimiento() { Producto = productoTelevisor, Cantidad = 99 });

            try
            {
                BLL.Services.MovimientoService.Current.TransferirStock(depoPacheco, carrefourBoulogne, detalleStockMovilizar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }            

            Console.WriteLine("STOCK FINAL");
            MostrarStock();

            Console.WriteLine("VIENDO LOS MOVIMIENTOS");

            foreach (var item in BLL.Services.MovimientoService.Current.GetAll())
            {
                Console.WriteLine($"Origen: {item.Origen.Nombre}, Destino: {item.Destino.Nombre} , Fecha: {item.Fecha} ");

                foreach (var detalle in item.DetalleMovimientos)
                {
                    Console.WriteLine($"Producto: {detalle.Producto.Descripcion}, Cantidad: {detalle.Cantidad}");
                }
            }
            
        }

        private static List<Almacen> MostrarStock()
        {
            List<Almacen> listadoDBAlmacenes = BLL.Services.AlmacenService.Current.SelectAll().ToList();

            foreach (var item in listadoDBAlmacenes)
            {
                Console.WriteLine(item.Nombre);
                Console.WriteLine("Stock del Almacen");
                foreach (var stock in item.Stock)
                {
                    Console.WriteLine($"Producto: {stock.Producto.Descripcion}, Cantidad: {stock.Cantidad}");
                }
            }

            return listadoDBAlmacenes;
        }
    }
}

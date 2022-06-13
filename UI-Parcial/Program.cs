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
            //Desafío: Generar una implementación similar parcial con UnitOfWork

            //Ejemplo de uso completo para un get de un producto determinado...
            Producto producto = BLL.Services.ProductoService.Current.SelectOne(Guid.Parse("43605EBA-D451-45B9-BAC3-E0667BC18E90"));
            Console.WriteLine("Prod " + producto.Descripcion);
            Console.WriteLine("Cod " + producto.Codigo);
            Console.WriteLine("Precio " + producto.Precio);


            //Generar una Tx completa con UnitOfWork y resolver los reportes solicitados

            Console.WriteLine("Paso 1: Completdo el artículo. Ojo que tengo con distinto tipo de dato el codigo de articulo... Presione cualquier tecla");
            Console.ReadKey();

            Producto oProducto = new Producto();
            oProducto.Codigo = "PELOTA-FT-N5";
            oProducto.Descripcion = "PELOTA FUTBOL NRO 5";
            oProducto.Precio = 1500;
            BLL.Services.ProductoService.Current.Add(oProducto);
            Console.WriteLine("Paso 2: Completé un Insert... Presione cualquier tecla");
            Console.ReadKey();




            Console.WriteLine("Hasta acá llegamos bien modificando el repository. (es el fin del using)");

            return; 








            ////////////////////////DEMO IN MEMORY//////////////////////////////////////////////////

            Console.WriteLine("STOCK INICIAL");
            List<Almacen> listadoDBAlmacenes = MostrarStock();            

            Tienda carrefourBoulogne = (Tienda)listadoDBAlmacenes[0];
            Deposito depoPacheco = (Deposito)listadoDBAlmacenes[2];

            Producto productoTelevisor = listadoDBAlmacenes[0].Stock[0].Producto;

            List<DetalleMovimiento> detalleStockMovilizar1 = new List<DetalleMovimiento>();
            detalleStockMovilizar1.Add(new DetalleMovimiento() { Producto = productoTelevisor, Cantidad = 99 });

            List<DetalleMovimiento> detalleStockMovilizar2 = new List<DetalleMovimiento>();
            detalleStockMovilizar2.Add(new DetalleMovimiento() { Producto = productoTelevisor, Cantidad = 1 });

            List<DetalleMovimiento> detalleStockMovilizar3 = new List<DetalleMovimiento>();
            detalleStockMovilizar3.Add(new DetalleMovimiento() { Producto = productoTelevisor, Cantidad = 5 });

            try
            {
                BLL.Services.MovimientoService.Current.TransferirStock(depoPacheco, carrefourBoulogne, detalleStockMovilizar1);
                BLL.Services.MovimientoService.Current.TransferirStock(depoPacheco, carrefourBoulogne, detalleStockMovilizar2);
                BLL.Services.MovimientoService.Current.TransferirStock(depoPacheco, carrefourBoulogne, detalleStockMovilizar3);                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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

using DAL.Contracts;
using DomainModel.DomainParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Memory
{
    public class AlmacenRepository : IGenericRepository<Almacen>
    {
        private List<Almacen> listadoAlmacenes = new List<Almacen>();

        public AlmacenRepository()
        {
            Producto televisor = new Producto();
            televisor.Codigo = "120";
            televisor.Descripcion = "Tv 60 pulgadas";
            televisor.Precio = 50000;

            Almacen carrefourBoulogne = new Tienda()
            {
                Id = Guid.NewGuid(),
                Nombre = "Carrefour Boulogne",
                Stock = new List<Stock>()
                {
                    new Stock(){ Producto =  televisor, Cantidad = 30}
                }
            };

            Almacen carrefourSanMartin = new Tienda()
            {
                Id = Guid.NewGuid(),
                Nombre = "Carrefour San Martín",
                Stock = new List<Stock>()
                {
                    new Stock(){ Producto =  televisor, Cantidad = 10}
                }
            };
        
            Almacen depositoPacheco = new Deposito()
            {
                Id = Guid.NewGuid(),
                Nombre = "Depósito Pacheco",
                Stock = new List<Stock>()
                {
                    new Stock(){ Producto =  televisor, Cantidad = 100}
                }
            };
    
            Almacen depositoRosario = new Deposito()
            {
                Id = Guid.NewGuid(),
                Nombre = "Depósito Rosario",
                Stock = new List<Stock>()
                {
                    new Stock(){ Producto =  televisor, Cantidad = 50}
                }
            };

            listadoAlmacenes.Add(carrefourBoulogne);
            listadoAlmacenes.Add(carrefourSanMartin);
            listadoAlmacenes.Add(depositoPacheco);
            listadoAlmacenes.Add(depositoRosario);
        }
        public void Add(Almacen obj)
        {
            listadoAlmacenes.Add(obj);
        }

        public void Delete(Guid id)
        {
            listadoAlmacenes.RemoveAll(o => o.Id == id);
        }

        public IEnumerable<Almacen> SelectAll()
        {
            return listadoAlmacenes;
        }

        public Almacen SelectOne(Guid id)
        {
            return listadoAlmacenes.FirstOrDefault(o => o.Id == id);
        }

        public void Update(Almacen obj)
        {
            Almacen almacenOriginal = listadoAlmacenes.FirstOrDefault(o => o.Id == obj.Id);
            if(almacenOriginal !=null)
            {
                //Operación de actualización...
                almacenOriginal.Localidad = obj.Localidad;
                almacenOriginal.Nombre = obj.Nombre;
                almacenOriginal.Provincia = obj.Provincia;
                almacenOriginal.Stock = obj.Stock;
            }
        }
    }
}

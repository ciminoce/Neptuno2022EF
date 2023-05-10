using Neptuno2022EF.Datos.Interfaces;
using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno2022EF.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly NeptunoDbContext _context;
        public RepositorioProductos(NeptunoDbContext context)
        {
            _context = context;
        }
        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
        }

        public void Borrar(int id)
        {
            var productoInDb=_context.Productos.SingleOrDefault(p=>p.ProductoId == id);
            if (productoInDb==null)
            {
                throw new Exception("Producto borrado por otro usuario");
            }
            _context.Entry(productoInDb).State =EntityState.Deleted;
        }

        public void Editar(Producto producto)
        {
            var productoInDb = _context.Productos.SingleOrDefault(p => p.ProductoId == producto.ProductoId);
            if (productoInDb == null)
            {
                throw new Exception("Producto borrado por otro usuario");
            }
            productoInDb.NombreProducto=producto.NombreProducto;
            productoInDb.CategoriaId=producto.CategoriaId;
            productoInDb.ProveedorId=producto.ProveedorId;
            productoInDb.StockMinimo=producto.StockMinimo;
            productoInDb.Stock=producto.Stock;
            productoInDb.StockMinimo=producto.StockMinimo;
            productoInDb.PrecioUnitario=producto.PrecioUnitario;
            productoInDb.Imagen=producto.Imagen;
            productoInDb.Suspendido=producto.Suspendido;
        }

        public bool EstaRelacionado(Producto producto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Producto producto)
        {
            throw new NotImplementedException();
        }

        public List<ProductoListDto> Filtrar(Func<Producto, bool> predicado)
        {
            throw new NotImplementedException();
        }

        public Producto GetProductoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoListDto> GetProductos()
        {
            throw new NotImplementedException();
        }

        public List<ProductoListDto> GetProductos(int paisId, int ciudadId)
        {
            throw new NotImplementedException();
        }
    }
}

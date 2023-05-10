using Neptuno2022EF.Entidades.Dtos;
using Neptuno2022EF.Entidades.Entidades;
using System;
using System.Collections.Generic;

namespace Neptuno2022EF.Datos.Interfaces
{
    internal interface IRepositorioProductos
    {
        void Agregar(Producto producto);
        void Borrar(int id);
        void Editar(Producto producto);
        bool EstaRelacionado(Producto producto);
        bool Existe(Producto producto);
        Producto GetProductoPorId(int id);
        List<ProductoListDto> GetProductos();
        List<ProductoListDto> GetProductos(int paisId, int ciudadId);
        List<ProductoListDto> Filtrar(Func<Producto, bool> predicado);

    }
}

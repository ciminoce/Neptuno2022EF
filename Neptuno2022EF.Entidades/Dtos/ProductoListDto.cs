using Neptuno2022EF.Entidades.Entidades;

namespace Neptuno2022EF.Entidades.Dtos
{
    public class ProductoListDto
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public bool Suspendido { get; set; }

    }
}

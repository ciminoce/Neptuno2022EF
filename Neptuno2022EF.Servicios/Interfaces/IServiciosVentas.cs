using Neptuno2022EF.Entidades.Dtos.Venta;
using System.Collections.Generic;

namespace Neptuno2022EF.Servicios.Interfaces
{
    public interface IServiciosVentas
    {
        List<VentaListDto> GetVentas();
    }
}

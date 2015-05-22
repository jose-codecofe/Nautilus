
//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using System;
using Nautilus.Dominio.Dto.Anexo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Dto
{
    public class ConfiguracionProductoDto : GeneralDto
    {
        public int Id { get; set; }
        public decimal PrecioVenta { get; set; }
        public int ProductoId { get; set; }
    }
}

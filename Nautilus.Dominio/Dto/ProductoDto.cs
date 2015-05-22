//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------

using Nautilus.Dominio.Dto.Anexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Dto
{
    public class ProductoDto :GeneralDto
    {      
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public string Observacion { get; set; }
        public string Codigo { get; set; }
        public decimal PrecioUnitario { get; set; }  
        public string TipoUnidad { get; set; }
    }
}

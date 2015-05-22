//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Dto.Anexo
{
    public class GeneralDto
    {
        private DateTime _bitacoraFecha;

        public GeneralDto()
        {
            _bitacoraFecha = DateTime.Now;
        }

        public DateTime BitacoraFecha { get { return _bitacoraFecha; } set { _bitacoraFecha = value; } }
        public string BitacoraUsuario { get; set; }
    }
}

//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using Nautilus.Dominio.Dto;
using Nautilus.Dominio.Dto.Anexo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Complemento
{
    public static class Contexto
    {
        public static InformacionDto GuardarModelo(DbContext pContexto)
        {
            InformacionDto vResultado = new InformacionDto();

            try
            {
                pContexto.SaveChanges();
                vResultado.EsCorrecto = true;
                vResultado.Mensaje = Constante.MENSAJE_PROCESOCORRECTO;
            }
            catch (Exception ex)
            {
                vResultado.EsCorrecto = false;
                vResultado.Mensaje = string.Format(Constante.FORMATO_MENSAJEERROR, ex.Message, ex.InnerException.InnerException.Message);
            }
            return vResultado;

        }
    }
}

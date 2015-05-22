﻿using Nautilus.Dominio.Complemento.Enumerador;
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
    public class MovimientoDto :GeneralDto
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public eTipoMovimiento TipoMovimiento  { get; set; }      
        public int ProductoId { get; set; }    
    }
}

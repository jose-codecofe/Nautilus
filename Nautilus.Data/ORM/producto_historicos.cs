//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------

namespace Nautilus.Data.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto_historicos
    {
        public int Id { get; set; }
        public int producto_Id { get; set; }
        public string nombre { get; set; }
        public string detalle { get; set; }
        public string observacion { get; set; }
        public string codigo { get; set; }
        public decimal precio_unitario { get; set; }
        public System.DateTime bitacora_fecha { get; set; }
        public string bitacora_usuario { get; set; }
        public string tipo_unidad { get; set; }
    }
}

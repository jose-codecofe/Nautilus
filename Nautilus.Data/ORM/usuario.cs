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
    
    public partial class usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string contrasenia { get; set; }
        public System.DateTime fecha_desde { get; set; }
        public System.DateTime fecha_hasta { get; set; }
        public bool es_activo { get; set; }
        public int empresa_Id { get; set; }
    
        public virtual empresa empresa { get; set; }
    }
}

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
    
    public partial class saldo_productos
    {
        public int Id { get; set; }
        public long cantidad { get; set; }
        public int producto_Id { get; set; }
    
        public virtual producto producto { get; set; }
    }
}

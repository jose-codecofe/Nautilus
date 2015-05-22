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
    
    public partial class empresa
    {
        public empresa()
        {
            this.usuarios = new HashSet<usuario>();
        }
    
        public int Id { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string nombre_ceo { get; set; }
        public string num_doc_ceo { get; set; }
        public string skype { get; set; }
        public string email_ceo { get; set; }
        public string site { get; set; }
    
        public virtual ICollection<usuario> usuarios { get; set; }
    }
}

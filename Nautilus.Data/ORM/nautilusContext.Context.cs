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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nautilusEntities : DbContext
    {
        public nautilusEntities()
            : base("name=nautilusEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<configuracion_productos> configuracion_productos { get; set; }
        public virtual DbSet<empresa> empresas { get; set; }
        public virtual DbSet<movimiento> movimientos { get; set; }
        public virtual DbSet<producto_historicos> producto_historicos { get; set; }
        public virtual DbSet<producto> productos { get; set; }
        public virtual DbSet<saldo_productos> saldo_productos { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
    }
}

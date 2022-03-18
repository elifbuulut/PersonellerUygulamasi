

namespace PersonellerUygulamasi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBPersonelsEntities2 : DbContext
    {
        public DBPersonelsEntities2()
            : base("name=DBPersonelsEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Personels> Tbl_Personels { get; set; }
    }
}

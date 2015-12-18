/*
* Created by: Yevgeniy A. Matveichev
* Created: 21/12/2015
* Copyright © Johnny Svarog, 2015
*/


namespace JSC.Host.DomainModels.EntityModels
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class JscHostContainer : DbContext
    {
        public JscHostContainer() : base("DefaultConnection")
            // todo: определить, для чего использовался ранее SingleConnection
            // : base(SingleDbConnection.Get("edmAdmin"))

        {

        }

        public JscHostContainer(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


        #region Properties section
        public DbSet<JSP_DicStatuses> DIC_EventSources { get; set; }
        #endregion
    }
}

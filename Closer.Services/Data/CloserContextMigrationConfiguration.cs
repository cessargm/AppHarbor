using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Closer.Services.Data
{
    public class CloserContextMigrationConfiguration : DbMigrationsConfiguration<CloserDataContext>
    {
        public CloserContextMigrationConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CloserDataContext context)
        {
            base.Seed(context);
        }
    }
}
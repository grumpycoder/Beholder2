using System.Data.Entity.Migrations;

namespace Domain.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppContext context)
        {

        }
    }
}

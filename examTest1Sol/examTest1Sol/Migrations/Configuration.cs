﻿namespace examTest1Sol.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<examTest1Sol.TeamData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "examTest1Sol.TeamData";
        }

        protected override void Seed(examTest1Sol.TeamData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

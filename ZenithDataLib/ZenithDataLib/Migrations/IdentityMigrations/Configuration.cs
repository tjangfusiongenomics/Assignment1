namespace ZenithDataLib.Migrations.IdentityMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\IdentityMigrations";
        }

        protected override void Seed(ZenithDataLib.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Activities.AddOrUpdate(i => i.ActivityId,

                    new Models.Activity
                    {
                     ActivityId = 1,
                     ActivityDescription = "soccer",
                     EventId = 1,
                     CreationData = new DateTime(2017, 2, 20, 8, 0, 0)
                    },
                    new Models.Activity
                    {
                     ActivityId = 2,
                     ActivityDescription = "basketball",
                     EventId = 2,
                     CreationData = new DateTime(2017, 2, 21, 8, 0, 0)
                    },
                    new Models.Activity
                    {
                     ActivityId = 3,
                     ActivityDescription = "vollyball",
                     EventId = 3,
                     CreationData = new DateTime(2017, 2, 22, 8, 0, 0)
                    }
            );

            context.Events.AddOrUpdate(i => i.EventId,

                    new Models.Event
                    {
                        EventId = 1,
                        EventFromDateAndTime = new DateTime(2017, 2, 22, 8, 0, 0),
                        EventToDateAndTime = new DateTime(2017, 2, 22, 10, 0, 0),
                        IsActive = true
                    },
                    new Models.Event
                    {
                        EventId = 2,
                        EventFromDateAndTime = new DateTime(2017, 2, 23, 8, 0, 0),
                        EventToDateAndTime = new DateTime(2017, 2, 24, 10, 0, 0),
                        IsActive = true
                    },
                    new Models.Event
                    {
                        EventId = 3,
                        EventFromDateAndTime = new DateTime(2017, 2, 24, 8, 0, 0),
                        EventToDateAndTime = new DateTime(2017, 2, 24, 10, 0, 0),
                        IsActive = false
                    }
            );
        }
    }
}

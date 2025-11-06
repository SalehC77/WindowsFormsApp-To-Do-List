namespace To_Do_List.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;
    internal sealed class Configuration : DbMigrationsConfiguration<To_Do_List.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(To_Do_List.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Roles.Add(new Role { Id = 1, Name = "Admin", Description = "Manages All System Operations" });
            context.Users.Add(new User { Id = 1, Username = "Saleh", Email = "salehbenjahlan@gmail.com", Password = "774361224", IsActive = true, RoleId = 1 });
            context.People.Add(new Person { Id = 1, FullName = "Saleh Abdullah omer ali ben jahlan", Age = 21, Gender = true, PhoneNumber = "774361224", Address = "Flak", DateOfBirth = DateTime.Parse("2004/2/4"), UserId = 1 });
            context.SaveChanges();

        }
    }
}

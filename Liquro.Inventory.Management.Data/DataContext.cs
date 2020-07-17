using System;
using System.Linq;
using System.Reflection;

using Liquro.Inventory.Management.Entities;

using Microsoft.EntityFrameworkCore;

namespace Liquro.Inventory.Management.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Alcohol> Alcohols { get; set; }

        public DbSet<AlcoholSupplier> AlcoholSuppliers { get; set; }

        public DbSet<CommonCode> Codes { get; set; }

        public DbSet<CommonCodeGroup> CodeGroups { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<OrderAlcohol> Orders { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var applyConfigurationMethod = typeof(ModelBuilder).GetMethod( nameof(ModelBuilder.ApplyConfiguration), System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract && !x.ContainsGenericParameters);

            foreach (var type in types)
            {
                foreach (var interfaceType in type.GetInterfaces())
                {
                    if (interfaceType.IsConstructedGenericType && interfaceType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                    {
                        var applyConfigurationConcreated = applyConfigurationMethod.MakeGenericMethod(interfaceType.GenericTypeArguments[0]);
                        applyConfigurationConcreated.Invoke(modelBuilder, new object[] { Activator.CreateInstance(type) });
                        break;
                    }
                }
            }

        }
    }
}

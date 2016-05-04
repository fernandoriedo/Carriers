using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Carriers.Domain.Entities;
using Carriers.Infra.Data.EntityConfig;

namespace Carriers.Infra.Data.Context
{
    public class CarriesContext : DbContext
    {
        public CarriesContext()
            : base("Carries")
        {

        }

        public DbSet<Carrier> Carrieres { get; set; }
        public DbSet<Rating> Ratings { get; set; }

#region Override's
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();    // Não deletar em cascata - Um para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();   // Não deletar em cascata - Muitos para muitos 

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());                                         // Propriedade que o nome for "nome"+Id, use como chave primaria

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));                        // Qualquer propriedade string, crie como varchar

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));                               // Tamanho Default 100

            modelBuilder.Configurations.Add(new CarrierConfiguration());
            modelBuilder.Configurations.Add(new RatingConfiguration());

        }

        // Deixar o DataCadastro sendo setado automaticamente 
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperties().FirstOrDefault(e => e.Name == "DateRegister") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateRegister").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateRegister").IsModified = false;
                }

            }

            return base.SaveChanges();
        }
#endregion
    }
}

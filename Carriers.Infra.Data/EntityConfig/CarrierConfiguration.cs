
using System.Data.Entity.ModelConfiguration;
using Carriers.Domain.Entities;

namespace Carriers.Infra.Data.EntityConfig
{
    public class CarrierConfiguration : EntityTypeConfiguration<Carrier>
    {
        public CarrierConfiguration()
        {
            HasKey(c => c.CarrierId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Address)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.PhoneNumber)
                           .IsRequired()
                           .HasMaxLength(20);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}

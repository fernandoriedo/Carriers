
using System.Data.Entity.ModelConfiguration;
using Carriers.Domain.Entities;

namespace Carriers.Infra.Data.EntityConfig
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(c => c.UserId);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Login)
                .IsRequired()
                .HasMaxLength(30);

            Property(c => c.Password)
                           .IsRequired()
                           .HasMaxLength(30);
        }
    }
}

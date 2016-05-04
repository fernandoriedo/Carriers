
using System.Data.Entity.ModelConfiguration;
using Carriers.Domain.Entities;

namespace Carriers.Infra.Data.EntityConfig
{
    public class RatingConfiguration : EntityTypeConfiguration<Rating>
    {
        public RatingConfiguration()
        {
            HasKey(p => p.RatingId);

            Property(p => p.Comment)
                .IsRequired()
                .HasMaxLength(500);

            Property(p => p.Note)
                .IsRequired();
        }
    }
}

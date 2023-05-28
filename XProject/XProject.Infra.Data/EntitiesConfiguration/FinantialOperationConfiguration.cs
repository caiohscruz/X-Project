using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XProject.Domain.Entitities;

namespace XProject.Infra.Data.EntitiesConfiguration
{
    public class FinantialOperationConfiguration : IEntityTypeConfiguration<FinantialOperation>
    {
        public void Configure(EntityTypeBuilder<FinantialOperation> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).HasMaxLength(100).IsRequired();
            builder.Property(t => t.Value).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired();         
        }
    }
}

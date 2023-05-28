using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XProject.Domain.Entitities;

namespace XProject.Infra.Data.EntitiesConfiguration
{
    public class ViewConfiguration : IEntityTypeConfiguration<AppPage>
    {
        public void Configure(EntityTypeBuilder<AppPage> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).HasMaxLength(50).IsRequired();

            builder.Property(t => t.Description).HasMaxLength(100).HasDefaultValue(string.Empty);

            builder.HasData(
                new AppPage()
                {
                    Name = "Home",
                    IsVisible = true,
                },
                new AppPage()
                {
                    Name = "Privacy",
                    IsVisible = true,
                },
                new AppPage()
                {
                    Name = "RandomPage",
                    IsVisible = true,
                },
                new AppPage()
                {
                    Name = "PageManagement",
                    IsVisible = true,
                });
        }
    }
}

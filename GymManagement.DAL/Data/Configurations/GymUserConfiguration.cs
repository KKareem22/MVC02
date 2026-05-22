using GymManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.DAL.Data.Configurations
{
    internal class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(u => u.Name).HasColumnType("varchar").HasMaxLength(50);

            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.Phone).HasMaxLength(11);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.Phone).IsUnique();

            builder.ToTable(ta =>
            {
                ta.HasCheckConstraint("EmailCheck", "Email Like '%___@%___%.__%'");
                ta.HasCheckConstraint("PhoneCheck", "Phone Like '^01[0125][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'");
            });
            builder.OwnsOne(u => u.Address, address =>
            {
                address.Property(a=>a.Street).HasColumnName("Street").HasColumnType("varchar").HasMaxLength(30);
                address.Property(a=>a.Street).HasColumnName("City").HasColumnType("varchar").HasMaxLength(30);

            });

        }
    }
}

using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeModel>
{
    public void Configure(EntityTypeBuilder<EmployeeModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(x => x.Contact).HasMaxLength(50);
        builder.Property(x => x.Email).HasMaxLength(100);
        builder.Property(x => x.Salary).IsRequired();
        builder.Property(x => x.WorkingHours);
        builder.Property(x => x.Position).IsRequired();
        builder.Property(x => x.HiringDate).IsRequired();
        builder.Property(x => x.Phone).HasMaxLength(30);
        builder.Property(x => x.HotelId).IsRequired();

    }
}

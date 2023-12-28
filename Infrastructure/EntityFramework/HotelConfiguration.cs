using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework;

public class HotelConfiguration : IEntityTypeConfiguration<HotelModel>
{
    public void Configure(EntityTypeBuilder<HotelModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.Street).HasMaxLength(100);
        builder.Property(x => x.Neighbourhood).HasMaxLength(50);
        builder.Property(x => x.StarsQuantity).IsRequired();
        builder.Property(x => x.State).IsRequired().HasMaxLength(30);
        builder.Property(x => x.City).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Country).IsRequired().HasMaxLength(30);
        builder.Property(x => x.Description).HasMaxLength(300);
        builder.Property(x => x.AddressNumber).IsRequired();
        builder.Property(x => x.AvailableRooms).IsRequired();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(50);
        builder.Property(x => x.FoundedIn);

        builder.HasMany(x => x.Employees)
            .WithOne()
            .HasForeignKey(x => x.HotelId);

        builder.HasMany(x => x.Rooms)
            .WithOne()
            .HasForeignKey(x => x.HotelId);

    }
}

using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework;

public class RoomConfiguration : IEntityTypeConfiguration<RoomModel>
{
    public void Configure(EntityTypeBuilder<RoomModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();


        builder.Property(x => x.Description).HasMaxLength(300);
        builder.Property(x => x.Number).IsRequired();
        builder.Property(x => x.Available).IsRequired();
        builder.Property(x => x.ReservationId);
        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.Price).IsRequired();
        builder.Property(x => x.HotelId).IsRequired();
    }
}

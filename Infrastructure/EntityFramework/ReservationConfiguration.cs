using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework;

public class ReservationConfiguration : IEntityTypeConfiguration<ReservationModel>
{
    public void Configure(EntityTypeBuilder<ReservationModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.GuestsNumber).IsRequired();
        builder.Property(x => x.CheckinDate).IsRequired();
        builder.Property(x => x.CheckoutDate).IsRequired();
        builder.Property(x => x.Code).IsRequired().HasMaxLength(30);

        builder.HasOne(x => x.Room)
            .WithOne(x => x.Reservation)
            .HasForeignKey<RoomModel>(x => x.ReservationId);

        builder.HasOne(x => x.Payment)
            .WithOne(x => x.Reservation)
            .HasForeignKey<PaymentModel>(x => x.ReservationId);
    }
}

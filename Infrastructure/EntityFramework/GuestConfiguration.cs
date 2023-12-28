using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework
{
    public class GuestConfiguration : IEntityTypeConfiguration<GuestModel>
    {
        public void Configure(EntityTypeBuilder<GuestModel> builder)
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

            builder.Property(x => x.DocumentNumber).HasMaxLength(100);
            builder.Property(x => x.CPF).HasMaxLength(15);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Contact).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Nationality).HasMaxLength(30);
            builder.Property(x => x.Phone).HasMaxLength(30);
            builder.Property(x => x.ReservationId).IsRequired();

            builder.HasOne(x => x.Reservation)
                .WithMany()
                .HasForeignKey(x => x.ReservationId);
        }
    }
}

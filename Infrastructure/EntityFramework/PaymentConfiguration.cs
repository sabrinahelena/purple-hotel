using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework
{
    public class PaymentConfiguration : IEntityTypeConfiguration<PaymentModel>
    {
        public void Configure(EntityTypeBuilder<PaymentModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.PaymentMethod).IsRequired();
            builder.Property(x => x.ReservationId);
            builder.Property(x => x.TotalAmount).IsRequired();
        }
    }
}

using Domain.AggregatesModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure;

public class PurpleHotelContext : DbContext
{
    public DbSet<EmployeeModel> Employee { get; set; }
    public DbSet<GuestModel> Guest { get; set; }
    public DbSet<HotelModel> Hotel { get; set; }
    public DbSet<PaymentModel> Payment { get; set; }
    public DbSet<ReservationModel> Reservation { get; set; }
    public DbSet<RoomModel> Room { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PurpleHotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);

    }

}

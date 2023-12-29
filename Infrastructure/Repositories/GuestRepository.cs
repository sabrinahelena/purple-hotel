using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class GuestRepository : IGuestRepository
{
    protected readonly PurpleHotelContext _context;

    public GuestRepository(PurpleHotelContext context)
    {
        this._context = context;
    }
    public async Task<int> CreateGuest(GuestModel guest)
    {
        await _context.Guest.AddAsync(guest);
        _context.SaveChanges();
        return guest.Id;
    }

    public async Task<List<GuestModel>> GetAllGuests()
    {
        return await _context.Guest.ToListAsync();
    }

    public async Task<List<GuestModel>> GetAllGuestsByReservationId(int reservationId)
    {
        return await _context.Guest.Where(x => x.ReservationId == reservationId).ToListAsync();
    }

    public async Task<GuestModel> GetGuestById(int id)
    {
        return await _context.Guest.FirstOrDefaultAsync(x => x.Id == id);
    }

    public bool UpdateGuest(GuestModel guest)
    {
        _context.Guest.Update(guest);
        _context.SaveChanges();
        return true;
    }
}

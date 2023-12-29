using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class HotelRepository : IHotelRepository
{
    protected readonly PurpleHotelContext _context;

    public HotelRepository(PurpleHotelContext context)
    {
        _context = context;
    }

    public async Task<int> CreateHotel(HotelModel hotel)
    {
        await _context.Hotel.AddAsync(hotel);
        _context.SaveChanges();
        return hotel.Id;
    }

    public async Task<List<HotelModel>> GetAllHotelsByCountry(string country)
    {
        return await _context.Hotel.Where(x => x.Country == country.ToUpper()).ToListAsync();
    }

    public async Task<HotelModel> GetHotelById(int id)
    {
        return await _context.Hotel.FirstOrDefaultAsync(x => x.Id == id);
    }

    public bool UpdateHotel(HotelModel hotel)
    {
        _context.Hotel.Update(hotel);
        _context.SaveChanges();
        return true;
    }
}

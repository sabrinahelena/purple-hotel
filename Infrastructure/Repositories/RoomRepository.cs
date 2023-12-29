using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RoomRepository : IRoomRepository
{
    protected readonly PurpleHotelContext _context;

    public RoomRepository(PurpleHotelContext context)
    {
        _context = context;
    }
    public async Task<int> CreateRoom(RoomModel room)
    {
         await _context.Room.AddAsync(room);
        _context.SaveChanges();
        return room.Id;
    }

    public async Task<List<RoomModel>> GetAllRoomsByAvailability(bool available)
    {
        return await _context.Room.Where(x => x.Available == available).ToListAsync();
    }

    public async Task<List<RoomModel>> GetAllRoomsByHotelId(int hotelId)
    {
        return await _context.Room.Where(x => x.HotelId == hotelId).ToListAsync();
    }

    public async Task<List<RoomModel>> GetAllRoomsByType(int type)
    {
        return await _context.Room.Where(x => x.Type == type).ToListAsync();
    }

    public async Task<RoomModel> GetRoomById(int id)
    {
        return await _context.Room.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<RoomModel> GetRoomByReservationCode(int reservationId)
    {
        return await _context.Room.FirstOrDefaultAsync(x => x.ReservationId == reservationId);
    }

    public bool UpdateRoom(RoomModel room)
    {
        _context.Room.Update(room);
        _context.SaveChanges();
        return true;
    }
}

using Domain.AggregatesModel;

namespace Infrastructure.Repositories.Interfaces;

public interface IRoomRepository
{
    Task<int> CreateRoom(RoomModel room);
    bool UpdateRoom(RoomModel room);
    Task<RoomModel> GetRoomById(int id);
    Task<List<RoomModel>> GetAllRoomsByType(int type);
    Task<List<RoomModel>> GetAllRoomsByAvailability(bool available);
    Task<List<RoomModel>> GetAllRoomsByHotelId(int hotelId);
    Task<RoomModel> GetRoomByReservationCode(int reservationId);
}

using Domain.AggregatesModel;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IGuestRepository
    {
        Task<int> CreateGuest(GuestModel guest);
        Task<bool> UpdateGuest(GuestModel guest);
        Task<GuestModel> GetGuestById(int id);
        Task<List<GuestModel>> GetAllGuestsByReservationId(int reservationId);
        Task<List<GuestModel>> GetAllGuests();
    }
}

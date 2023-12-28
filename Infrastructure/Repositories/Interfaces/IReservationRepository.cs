using Domain.AggregatesModel;

namespace Infrastructure.Repositories.Interfaces;

public interface IReservationRepository
{
    Task<int> CreateReservation(ReservationModel reservation);
    Task<bool> UpdateReservation(ReservationModel reservation);
    Task<ReservationModel> GetReservationById(int reservationId);
    Task<ReservationModel> GetReservationByCode(string code);
    Task<List<ReservationModel>> GetAllReservationsByStatus(int reservationStatus);
}

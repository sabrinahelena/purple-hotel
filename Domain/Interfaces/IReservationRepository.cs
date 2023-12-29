using Domain.AggregatesModel;

namespace Domain.Interfaces;

public interface IReservationRepository
{
    Task<int> CreateReservation(ReservationModel reservation, CancellationToken cToken);
    bool UpdateReservation(ReservationModel reservation);
    Task<ReservationModel> GetReservationById(int reservationId, CancellationToken cToken);
    Task<ReservationModel> GetReservationByCode(string code, CancellationToken cToken);
    Task<List<ReservationModel>> GetAllReservationsByStatus(int reservationStatus, CancellationToken cToken);
}

using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ReservationRepository : IReservationRepository
{
    protected readonly PurpleHotelContext _context;

    public ReservationRepository(PurpleHotelContext context)
    {
        _context = context;
    }
    public async Task<int> CreateReservation(ReservationModel reservation, CancellationToken cToken)
    {
        await _context.Reservation.AddAsync(reservation);
        await _context.SaveChangesAsync(cToken);
        return reservation.Id;
    }

    public async Task<List<ReservationModel>> GetAllReservationsByStatus(int reservationStatus, CancellationToken cToken)
    {
        return await _context.Reservation.Where(x => x.Status == reservationStatus).ToListAsync(cToken);
    }

    public async Task<ReservationModel> GetReservationByCode(string code, CancellationToken cToken)
    {
        return await _context.Reservation.Where(x => x.Code == code).FirstOrDefaultAsync(cToken);
    }

    public async Task<ReservationModel> GetReservationById(int reservationId, CancellationToken cToken)
    {
        return await _context.Reservation.Where(x => x.Id == reservationId).FirstOrDefaultAsync(cToken);
    }

    public bool UpdateReservation(ReservationModel reservation)
    {
        _context.Reservation.Update(reservation);
        _context.SaveChanges();
        return true;
    }
}

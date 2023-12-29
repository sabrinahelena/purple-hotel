using Domain.AggregatesModel;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PaymentRepository : IPaymentRepository
{
    protected readonly PurpleHotelContext _context;

    public PaymentRepository(PurpleHotelContext context)
    {
        _context = context;
    }

    public async Task<int> CreatePayment(PaymentModel payment)
    {
        await _context.Payment.AddAsync(payment);
        _context.SaveChanges();
        return payment.Id;
    }

    public async Task<List<PaymentModel>> GetAllPaymentsByReservationCode(int reservationId)
    {
        return await _context.Payment.Where(x => x.ReservationId == reservationId).ToListAsync();
    }

    public async Task<PaymentModel> GetPaymentById(int id)
    {
        return await _context.Payment.FirstOrDefaultAsync(x => x.Id == id);
    }

    public bool UpdatePayment(PaymentModel payment)
    {
        _context.Payment.Update(payment);
        _context.SaveChanges();
        return true;
    }
}

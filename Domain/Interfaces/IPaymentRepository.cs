using Domain.AggregatesModel;

namespace Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Task<int> CreatePayment(PaymentModel payment);
        bool UpdatePayment(PaymentModel payment);
        Task<PaymentModel> GetPaymentById(int id);
        Task<List<PaymentModel>> GetAllPaymentsByReservationCode(int reservationId);
    }
}

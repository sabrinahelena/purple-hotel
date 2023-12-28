using Application.DTOs.Request.Enums;

namespace Application.DTOs.Request;

public class PaymentRequest
{
    public EPaymentMethod PaymentMethod { get; init; }
    public double TotalAmount { get; init; }
    public EPaymentStatus Status { get; init; }
    public int ReservationId { get; init; }
}

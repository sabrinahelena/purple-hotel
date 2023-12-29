using Application.DTOs.Request.Enums;

namespace Application.DTOs.Request.ReservationRequest;

public class ReservationRequest
{
    public string Code { get; init; } = string.Empty;
    public DateTime CheckinDate { get; init; }
    public DateTime CheckoutDate { get; init; }
    public int GuestsNumber { get; init; }
    public EReservationStatus Status { get; init; }
    public ReservationRoomRequest? Room { get; init; }
    public PaymentRequest? Payment { get; init; }
}

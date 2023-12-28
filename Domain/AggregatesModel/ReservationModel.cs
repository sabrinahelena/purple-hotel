namespace Domain.AggregatesModel;

public class ReservationModel
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public DateTime CheckinDate { get; init; }
    public DateTime CheckoutDate { get; init; }
    public int GuestsNumber { get; init; }
    public int Status { get; init; }
    public RoomModel Room { get; init; }
    public PaymentModel Payment { get; init; }
}

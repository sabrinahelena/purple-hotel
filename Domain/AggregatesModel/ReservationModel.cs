namespace Domain.AggregatesModel;

public class ReservationModel
{
    public int Id { get; init; }
    public string Code { get; private set; } = string.Empty;
    public DateTime CheckinDate { get; private set; }
    public DateTime CheckoutDate { get; private set; }
    public int GuestsNumber { get; private set; }
    public int Status { get; private set; }
    public RoomModel Room { get; init; }
    public PaymentModel Payment { get; init; }
}

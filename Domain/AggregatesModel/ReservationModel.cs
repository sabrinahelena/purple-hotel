namespace Domain.AggregatesModel;

public class ReservationModel
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public DateTime CheckinDate { get; set; }
    public DateTime CheckoutDate { get; set; }
    public int GuestsNumber { get; set; }
    public int Status { get; set; }
    public RoomModel Room { get; set; }
    public PaymentModel Payment { get; set; }
}

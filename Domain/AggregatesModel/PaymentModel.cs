namespace Domain.AggregatesModel;

public class PaymentModel
{
    public int Id { get; init; }
    public int PaymentMethod { get; private set; }
    public double TotalAmount { get; private set; }
    public int Status { get; private set; }
    public int ReservationId { get; private set; }
    public ReservationModel Reservation { get; init; }
}

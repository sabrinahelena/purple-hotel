namespace Domain.AggregatesModel;

public class PaymentModel
{
    public int Id { get; init; }
    public int PaymentMethod { get; init; }
    public double TotalAmount { get; init; }
    public int Status { get; init; }
    public int ReservationId { get; init; }
    public ReservationModel Reservation { get; init; }
}

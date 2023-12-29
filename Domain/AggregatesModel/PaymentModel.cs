namespace Domain.AggregatesModel;

public class PaymentModel
{
    public int Id { get; init; }
    public int PaymentMethod { get; set; }
    public double TotalAmount { get; set; }
    public int Status { get; set; }
    public int ReservationId { get; set; }
    public ReservationModel Reservation { get; set; }
}

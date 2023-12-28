namespace Domain.AggregatesModel;

public class GuestModel
{
    public int Id { get; init; }
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set; } = string.Empty;
    public string CPF { get; private set; } = string.Empty;
    public string DocumentNumber { get; private set; } = string.Empty;
    public string Contact { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public DateTime BirthDate { get; private set; }
    public string Nationality { get; private set; } = string.Empty;
    public int ReservationId { get; private set; }
    public ReservationModel Reservation { get; init; }
}

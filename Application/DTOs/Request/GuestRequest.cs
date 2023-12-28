using Application.DTOs.Request.ValueObjects;

namespace Application.DTOs.Request;

public class GuestRequest
{
    public string Name { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string CPF { get; init; } = string.Empty;
    public string DocumentNumber { get; init; } = string.Empty;
    public string Contact { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public EmailValue? Email { get; init; };
    public DateTime BirthDate { get; init; }
    public string Nationality { get; init; } = string.Empty;
    public int ReservationId { get; set; }
}

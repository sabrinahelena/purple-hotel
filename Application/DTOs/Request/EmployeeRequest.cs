using Application.DTOs.Request.Enums;
using Application.DTOs.Request.ValueObjects;

namespace Application.DTOs.Request;

public class EmployeeRequest
{
    public string Name { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public EPosition Position { get; init; }
    public DateTime HiringDate { get; init; }
    public string Contact { get; init; } = string.Empty;
    public string Phone { get; init; } = string.Empty;
    public EmailValue? Email { get; init; }
    public double Salary { get; init; }
    public int? WorkingHours { get; init; }
    public int HotelId { get; init; }

}

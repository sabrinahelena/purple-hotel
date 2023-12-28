using Application.DTOs.Request.Enums;

namespace Application.DTOs.Request;

public class RoomRequest
{
    /// <summary>
    /// RoomNumber
    /// </summary>
    public int Number { get; init; }

    /// <summary>
    /// RoomType
    /// </summary>
    public ERoomType Type { get; init; }

    /// <summary>
    /// Price per night
    /// </summary>
    public double Price { get; init; }

    /// <summary>
    /// Availability
    /// </summary>
    public bool Available { get; init; }
    public string Description { get; init; } = string.Empty;
    public int HotelId { get; init; }
    public int ReservationId { get; init; }
}
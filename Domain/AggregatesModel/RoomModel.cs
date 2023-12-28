namespace Domain.AggregatesModel;

public class RoomModel
{
    public int Id { get; init; }

    /// <summary>
    /// RoomNumber
    /// </summary>
    public int Number { get; init; }

    /// <summary>
    /// RoomType
    /// </summary>
    public int Type { get; init; }

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
    public ReservationModel Reservation { get; init; }

}

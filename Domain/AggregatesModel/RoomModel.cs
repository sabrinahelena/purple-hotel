namespace Domain.AggregatesModel;

public class RoomModel
{
    public int Id { get; init; }

    /// <summary>
    /// RoomNumber
    /// </summary>
    public int Number { get; private set; }

    /// <summary>
    /// RoomType
    /// </summary>
    public int Type { get; private set; }

    /// <summary>
    /// Price per night
    /// </summary>
    public double Price { get; private set; }

    /// <summary>
    /// Availability
    /// </summary>
    public bool Available { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public int HotelId { get; private set; }
    public int ReservationId { get; private set; }
    public ReservationModel Reservation { get; init; }

}

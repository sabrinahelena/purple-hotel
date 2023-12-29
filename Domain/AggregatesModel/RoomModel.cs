namespace Domain.AggregatesModel;

public class RoomModel
{
    public int Id { get; set; }

    /// <summary>
    /// RoomNumber
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// RoomType
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Price per night
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Availability
    /// </summary>
    public bool Available { get; set; }
    public string Description { get; set; } = string.Empty;
    public int HotelId { get; set; }
    public int? ReservationId { get; set; }
    public ReservationModel? Reservation { get; set; }

}

namespace AirCompany.Domain;

/// <summary>
/// Represents a <see cref="Ticket"/> issued to a <see cref="Passenger"/> for a specific <see cref="Flight"/>
/// </summary>
public class Ticket
{
    /// <summary>
    /// The unique identifier for the <see cref="Ticket"/>
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// <see cref="Flight"/> associated with this <see cref="Ticket"/>
    /// </summary>
    public required Flight Flight { get; set; }

    /// <summary>
    /// <see cref="Passenger"/> who owns this <see cref="Ticket"/>
    /// </summary>
    public required Passenger Passenger { get; set; }

    /// <summary>
    /// The seat number assigned to this <see cref="Ticket"/>
    /// </summary>
    public required string SeatNumber { get; set; }

    /// <summary>
    /// Indicates whether the <see cref="Passenger"/> has hand luggage for this <see cref="Ticket"/>
    /// </summary>
    public bool? HasHandLuggage { get; set; }

    /// <summary>
    /// Total baggage weight (in kilograms) for this <see cref="Ticket"/>
    /// </summary>
    public double? TotalBaggageWeightKg { get; set; }
}

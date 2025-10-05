namespace AirCompany.Domain;

/// <summary>
/// Represents a <see cref="Flight"/> with route and schedule information
/// </summary>
public class Flight
{
    /// <summary>
    /// The unique identifier for the <see cref="Flight"/>
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Code identifying the <see cref="Flight"/>
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// Departure airport for this <see cref="Flight"/>
    /// </summary>
    public required string DepartureAirport { get; set; }

    /// <summary>
    /// Arrival airport for this <see cref="Flight"/>
    /// </summary>
    public required string ArrivalAirport { get; set; }

    /// <summary>
    /// Departure date and time of the <see cref="Flight"/>
    /// </summary>
    public DateTime? DepartureDateTime { get; set; }

    /// <summary>
    /// Arrival date and time of the <see cref="Flight"/>
    /// </summary>
    public DateTime? ArrivalDateTime { get; set; }

    /// <summary>
    /// Duration of this <see cref="Flight"/>
    /// </summary>
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// <see cref="AircraftModel"/> used for this <see cref="Flight"/>
    /// </summary>
    public required AircraftModel AircraftModel { get; set; }
}

namespace AirCompany.Domain.Entities;

/// <summary>
/// Represents a flight with route and schedule information
/// </summary>
public class Flight
{
    /// <summary>
    /// The unique identifier for the flight
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Code identifying the flight
    /// </summary>
    public required string Code { get; set; }

    /// <summary>
    /// Departure airport for this flight
    /// </summary>
    public required string DepartureAirport { get; set; }

    /// <summary>
    /// Arrival airport for this flight
    /// </summary>
    public required string ArrivalAirport { get; set; }

    /// <summary>
    /// Departure date and time of the flight
    /// </summary>
    public DateTime? DepartureDateTime { get; set; }

    /// <summary>
    /// Arrival date and time of the flight
    /// </summary>
    public DateTime? ArrivalDateTime { get; set; }

    /// <summary>
    /// Duration of this flight
    /// </summary>
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// <see cref="AircraftModel"/> used for this flight
    /// </summary>
    public required AircraftModel AircraftModel { get; set; }
}

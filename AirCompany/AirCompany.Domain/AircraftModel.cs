namespace AirCompany.Domain;

/// <summary>
/// Represents an <see cref="AircraftModel"/> with technical specifications
/// </summary>
public class AircraftModel
{
    /// <summary>
    /// The unique identifier for the <see cref="AircraftModel"/>
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// <see cref="AircraftFamily"/> that this <see cref="AircraftModel"/> belongs to
    /// </summary>
    public required AircraftFamily AircraftFamily { get; set; }

    /// <summary>
    /// Name of the <see cref="AircraftModel"/>
    /// </summary>
    public required string ModelName { get; set; }

    /// <summary>
    /// Flight range (in kilometers) for this <see cref="AircraftModel"/>
    /// </summary>
    public required double FlightRangeKm { get; set; }

    /// <summary>
    /// Passenger capacity of the <see cref="AircraftModel"/>
    /// </summary>
    public required int PassengerCapacity { get; set; }

    /// <summary>
    /// Cargo capacity (in kilograms) for the <see cref="AircraftModel"/>
    /// </summary>
    public required double CargoCapacityKg { get; set; }
}

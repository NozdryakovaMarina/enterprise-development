namespace AirCompany.Domain.Entities;

/// <summary>
/// Represents an <see cref="AircraftFamily"/>
/// </summary>
public class AircraftFamily
{
    /// <summary>
    /// The unique identifier for the <see cref="AircraftFamily"/>
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Name of the <see cref="AircraftFamily"/>
    /// </summary>
    public required string FamilyName { get; set; }

    /// <summary>
    /// Manufacturer of the <see cref="AircraftFamily"/>
    /// </summary>
    public required string Manufacturer { get; set; }
}

namespace AirCompany.Domain.Entities;

/// <summary>
/// Represents an aircraft family
/// </summary>
public class AircraftFamily
{
    /// <summary>
    /// The unique identifier for the aircraft family
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Name of the aircraft family
    /// </summary>
    public required string FamilyName { get; set; }

    /// <summary>
    /// Manufacturer of the aircraft family
    /// </summary>
    public required string Manufacturer { get; set; }
}

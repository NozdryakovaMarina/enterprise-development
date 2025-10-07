namespace AirCompany.Domain.Entities;

/// <summary>
/// Represents a <see cref="Passenger"/> of the airline
/// </summary>
public class Passenger
{
    /// <summary>
    /// The unique identifier for the <see cref="Passenger"/>
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Passport number of the <see cref="Passenger"/>
    /// </summary>
    public required string PassportNumber { get; set; }

    /// <summary>
    /// Full name of the <see cref="Passenger"/>
    /// </summary>
    public required string FullName { get; set; }

    /// <summary>
    /// Birth date of the <see cref="Passenger"/>
    /// </summary>
    public DateOnly? BirthDate { get; set; }
}

﻿namespace AirCompany.Domain.Entities;

/// <summary>
/// Represents an aircraft model with technical specifications
/// </summary>
public class AircraftModel
{
    /// <summary>
    /// The unique identifier for the aircraft model
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// <see cref="AircraftFamily"/> that this aircraft model belongs to
    /// </summary>
    public required AircraftFamily AircraftFamily { get; set; }

    /// <summary>
    /// Name of the <see cref="AircraftModel"/>
    /// </summary>
    public required string ModelName { get; set; }

    /// <summary>
    /// Flight range (in kilometers) for this aircraft model
    /// </summary>
    public required double FlightRangeKm { get; set; }

    /// <summary>
    /// Passenger capacity of the aircraft model
    /// </summary>
    public required int PassengerCapacity { get; set; }

    /// <summary>
    /// Cargo capacity (in kilograms) for the aircraft model
    /// </summary>
    public required double CargoCapacityKg { get; set; }
}

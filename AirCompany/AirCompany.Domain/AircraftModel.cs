namespace AirCompany.Domain;

public class AircraftModel
{
    public required int Id { get; set; }
    public required AircraftFamily AircraftFamily { get; set; }
    public required string ModelName { get; set; }
    public required double FlightRangeKm { get; set; }
    public required int PassengerCapacity { get; set; }
    public required double CargoCapacityKg { get; set; }
}

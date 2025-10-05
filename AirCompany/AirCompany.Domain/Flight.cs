namespace AirCompany.Domain;

public class Flight
{
    public required int Id { get; set; }
    public required string Code { get; set; }
    public required string DepartureAirport { get; set; }
    public required string ArrivalAirport { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public TimeSpan? Duration { get; set; }
    public required AircraftModel AircraftModel { get; set; }
}

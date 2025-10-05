namespace AirCompany.Domain;

public class Ticket
{
    public required int Id { get; set; }
    public required Flight Flight { get; set; }
    public required Passenger Passenger { get; set; }
    public required string SeatNumber { get; set; }
    public bool? HasHandLuggage { get; set; }
    public double? TotalBaggageWeightKg { get; set; }
}

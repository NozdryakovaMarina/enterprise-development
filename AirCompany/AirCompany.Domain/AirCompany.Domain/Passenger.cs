namespace AirCompany.Domain;

public class Passenger
{
    public required int Id { get; set; }
    public required string PassportNumber { get; set; }
    public required string FullName { get; set; }
    public DateOnly? BirthDate { get; set; }
}

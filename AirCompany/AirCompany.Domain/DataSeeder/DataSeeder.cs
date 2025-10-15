using AirCompany.Domain.Entities;

namespace AirCompany.Domain.DataSeeder;

public class DataSeeder
{
    private readonly List<AircraftFamily> _aircraftFamilies;
    private readonly List<AircraftModel> _aircraftModels;
    private readonly List<Flight> _flights;
    private readonly List<Passenger> _passengers;
    private readonly List<Ticket> _tickets;

    public DataSeeder()
    {
        _aircraftFamilies = InitAircraftFamily();
        _aircraftModels = InitAircraftModel(_aircraftFamilies);
        _flights = InitFlight(_aircraftModels);
        _passengers = InitPassenger();
        _tickets = InitTicket(_passengers, _flights);
    }

    public List<AircraftFamily> AircraftFamilies => _aircraftFamilies;
    public List<AircraftModel> AircraftModels => _aircraftModels;   
    public List <Flight> Flights => _flights;
    public List<Passenger> Passengers => _passengers;
    public List<Ticket> Tickets => _tickets;

    private static List<AircraftFamily> InitAircraftFamily() => [
        new AircraftFamily {Id = 1, FamilyName = "SSJ100", Manufacturer = "Sukhoi"},
        new AircraftFamily {Id = 2, FamilyName = "A319", Manufacturer = "Airbus"},
        new AircraftFamily {Id = 3, FamilyName = "737", Manufacturer = "Boeing"},
        new AircraftFamily {Id = 4, FamilyName = "777", Manufacturer = "Boeing"},
        new AircraftFamily {Id = 5, FamilyName = "E-Jets", Manufacturer = "Embraer"},
        new AircraftFamily {Id = 6, FamilyName = "A321", Manufacturer = "Airbus"},
        new AircraftFamily {Id = 7, FamilyName = "A330", Manufacturer = "Airbus"},
        new AircraftFamily {Id = 8, FamilyName = "747", Manufacturer = "Boeing"},
        new AircraftFamily {Id = 9, FamilyName = "A350", Manufacturer = "Airbus"},
        new AircraftFamily {Id = 10, FamilyName = "A320", Manufacturer = "Airbus"}
        ];

    public static List<AircraftModel> InitAircraftModel(List<AircraftFamily> families) => [
        new AircraftModel 
        {
            Id = 1, 
            ModelName = "SSJ100-95LR", 
            PassengerCapacity = 103, 
            CargoCapacityKg = 49450, 
            FlightRangeKm = 4578, 
            AircraftFamily = families[0]
        },
        new AircraftModel 
        {
            Id = 2, 
            ModelName = "A319-100", 
            PassengerCapacity = 138, 
            CargoCapacityKg = 68000, 
            FlightRangeKm = 4910, 
            AircraftFamily = families[1]
        },
        new AircraftModel 
        {
            Id = 3, 
            ModelName = "737-800", 
            PassengerCapacity = 189, 
            CargoCapacityKg = 79015, 
            FlightRangeKm = 5427, 
            AircraftFamily = families[2]
        },
        new AircraftModel 
        {
            Id = 4, 
            ModelName = "777-300ER", 
            PassengerCapacity = 408, 
            CargoCapacityKg = 317500, 
            FlightRangeKm = 11200, 
            AircraftFamily = families[3]
        },
        new AircraftModel 
        {
            Id = 5, 
            ModelName = "E170", 
            PassengerCapacity = 78, 
            CargoCapacityKg = 37200, 
            FlightRangeKm = 3800, 
            AircraftFamily = families[4]
        },
        new AircraftModel 
        {
            Id = 6, 
            ModelName = "A321NEO", 
            PassengerCapacity = 244, 
            CargoCapacityKg = 93500, 
            FlightRangeKm = 5500, 
            AircraftFamily = families[5]
        },
        new AircraftModel 
        {
            Id = 7, 
            ModelName = "A330-300", 
            PassengerCapacity = 440, 
            CargoCapacityKg = 230000, 
            FlightRangeKm = 9500, 
            AircraftFamily = families[6]
        },
        new AircraftModel 
        {
            Id = 8, 
            ModelName = "747-400", 
            PassengerCapacity = 522, 
            CargoCapacityKg = 396890, 
            FlightRangeKm = 13450, 
            AircraftFamily = families[7]
        },
        new AircraftModel 
        {
            Id = 9, 
            ModelName = "A350-900",
            PassengerCapacity = 440, 
            CargoCapacityKg = 268000, 
            FlightRangeKm = 12400, 
            AircraftFamily = families[8]
        },
        new AircraftModel 
        {
            Id = 10, 
            ModelName = "A320NEO", 
            PassengerCapacity = 149, 
            CargoCapacityKg = 75500, 
            FlightRangeKm = 4800, 
            AircraftFamily = families[9]
        }
    ];

    private static List<Flight> InitFlight(List<AircraftModel> models) => [
        new Flight
        {
            Id = 1,
            Code = "U6713",
            DepartureAirport = "SVX",
            ArrivalAirport = "DME",
            DepartureDateTime = new DateTime(2025, 10, 7, 6, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 7, 8, 0, 0),
            Duration = TimeSpan.FromHours(2),
            AircraftModel = models[0]
        },
        new Flight
        {
            Id = 2,
            Code = "SU2602",
            DepartureAirport = "SVO",
            ArrivalAirport = "LED",
            DepartureDateTime = new DateTime(2025, 10, 8, 7, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 8, 8, 0, 0),
            Duration = TimeSpan.FromHours(1),
            AircraftModel = models[1]
        },
        new Flight
        {
            Id = 3,
            Code = "SU2603",
            DepartureAirport = "LED",
            ArrivalAirport = "SVO",
            DepartureDateTime = new DateTime(2025, 10, 9, 10, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 9, 11, 0, 0),
            Duration = TimeSpan.FromHours(1),
            AircraftModel = models[2]
        },
        new Flight
        {
            Id = 4,
            Code = "S70105",
            DepartureAirport = "DME",
            ArrivalAirport = "OVB",
            DepartureDateTime = new DateTime(2025, 10, 10, 23, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 11, 3, 0, 0),
            Duration = TimeSpan.FromHours(4),
            AircraftModel = models[3]
        },
        new Flight
        {
            Id = 5,
            Code = "UT233",
            DepartureAirport = "VKO",
            ArrivalAirport = "TJM",
            DepartureDateTime = new DateTime(2025, 10, 12, 10, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 12, 13, 0, 0),
            Duration = TimeSpan.FromHours(3),
            AircraftModel = models[4]
        },
        new Flight
        {
            Id = 6,
            Code = "SU1217",
            DepartureAirport = "KUF",
            ArrivalAirport = "SVO",
            DepartureDateTime = new DateTime(2025, 10, 13, 22, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 14, 0, 0, 0),
            Duration = TimeSpan.FromHours(2),
            AircraftModel = models[5]
        },
        new Flight
        {
            Id = 7,
            Code = "SU520",
            DepartureAirport = "SVO",
            ArrivalAirport = "DXB",
            DepartureDateTime = new DateTime(2025, 10, 15, 7, 25, 0),
            ArrivalDateTime = new DateTime(2025, 10, 15, 14, 25, 0),
            Duration = TimeSpan.FromHours(5),
            AircraftModel = models[6]
        },
        new Flight
        {
            Id = 8,
            Code = "SU2964",
            DepartureAirport = "AER",
            ArrivalAirport = "KUF",
            DepartureDateTime = new DateTime(2025, 10, 16, 12, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 16, 15, 0, 0),
            Duration = TimeSpan.FromHours(3),
            AircraftModel = models[7]
        },
        new Flight
        {
            Id = 9,
            Code = "SU214",
            DepartureAirport = "SVO",
            ArrivalAirport = "JFK",
            DepartureDateTime = new DateTime(2025, 10, 17, 1, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 17, 19, 0, 0),
            Duration = TimeSpan.FromHours(18),
            AircraftModel = models[8]
        },
        new Flight
        {
            Id = 10,
            Code = "DP751",
            DepartureAirport = "VKO",
            ArrivalAirport = "SVX",
            DepartureDateTime = new DateTime(2025, 10, 18, 16, 0, 0),
            ArrivalDateTime = new DateTime(2025, 10, 18, 18, 0, 0),
            Duration = TimeSpan.FromHours(2),
            AircraftModel = models[9]
        }
        ];

    private static List<Passenger> InitPassenger() => [
        new Passenger {Id = 1, PassportNumber = "716546245", FullName = "Sidorova Anna Sergeevna", BirthDate = new DateOnly(2002, 5, 18)},
        new Passenger {Id = 2, PassportNumber = "651465468", FullName = "Alekseev V.", BirthDate = new DateOnly(1996, 7, 14)},
        new Passenger {Id = 3, PassportNumber = "168425152", FullName = "Kozlov Dmitry Vladimirovich", BirthDate = new DateOnly(1995, 4, 12)},
        new Passenger {Id = 4, PassportNumber = "425682755", FullName = "Pavlova Maria Viktorovna", BirthDate = new DateOnly(1973, 9, 18)},
        new Passenger {Id = 5, PassportNumber = "818928973", FullName = "Koroleva Tatiana Olegovna", BirthDate = new DateOnly(1987, 12, 8)},
        new Passenger {Id = 6, PassportNumber = "979812364", FullName = "Petrov P.", BirthDate = new DateOnly(1976, 3, 16)},
        new Passenger {Id = 7, PassportNumber = "245687261", FullName = "Nikolaev N.", BirthDate = new DateOnly(2006, 11, 30)},
        new Passenger {Id = 8, PassportNumber = "358143898", FullName = "Alexandrova Olga", BirthDate = new DateOnly(2004, 6, 3)},
        new Passenger {Id = 9, PassportNumber = "584555219", FullName = "Mikheev Vasily", BirthDate = new DateOnly(1961, 6, 25)},
        new Passenger {Id = 10, PassportNumber = "906442887", FullName = "Smirnov S.", BirthDate = new DateOnly(1986, 5, 19)},
        new Passenger {Id = 11, PassportNumber = "315764121", FullName = "Sergeev Oleg", BirthDate = new DateOnly(1993, 8, 7)},
        new Passenger {Id = 12, PassportNumber = "174095946", FullName = "Morozov Andrey", BirthDate = new DateOnly(2000, 10, 3)}
        ];

    private static List<Ticket> InitTicket(List<Passenger> passengers, List<Flight> flights) => [
        new Ticket {Id = 1, Flight = flights[0], Passenger = passengers[0], SeatNumber = "12A", HasHandLuggage = false, TotalBaggageWeightKg = 0},
        new Ticket {Id = 2, Flight = flights[0], Passenger = passengers[1], SeatNumber = "12B", HasHandLuggage = false, TotalBaggageWeightKg = 18},
        new Ticket {Id = 3, Flight = flights[0], Passenger = passengers[2], SeatNumber = "12C", HasHandLuggage = true, TotalBaggageWeightKg = 0},

        new Ticket {Id = 4, Flight = flights[1], Passenger = passengers[3], SeatNumber = "15D", HasHandLuggage = true, TotalBaggageWeightKg = 0},
        new Ticket {Id = 5, Flight = flights[1], Passenger = passengers[4], SeatNumber = "15E", HasHandLuggage = false, TotalBaggageWeightKg = 7},
        new Ticket {Id = 6, Flight = flights[1], Passenger = passengers[5], SeatNumber = "15F", HasHandLuggage = true, TotalBaggageWeightKg = 10},

        new Ticket {Id = 7, Flight = flights[2], Passenger = passengers[6], SeatNumber = "7A", HasHandLuggage = false, TotalBaggageWeightKg = 13},
        new Ticket {Id = 8, Flight = flights[2], Passenger = passengers[7], SeatNumber = "7B", HasHandLuggage = false, TotalBaggageWeightKg = 25},

        new Ticket {Id = 9, Flight = flights[3], Passenger = passengers[10], SeatNumber = "21C", HasHandLuggage = true, TotalBaggageWeightKg = 0},
        new Ticket {Id = 10, Flight = flights[3], Passenger = passengers[11], SeatNumber = "21D", HasHandLuggage = false, TotalBaggageWeightKg = 12},

        new Ticket {Id = 11, Flight = flights[4], Passenger = passengers[4], SeatNumber = "5A", HasHandLuggage = false, TotalBaggageWeightKg = 17},
        new Ticket {Id = 12, Flight = flights[4], Passenger = passengers[8], SeatNumber = "5B", HasHandLuggage = true, TotalBaggageWeightKg = 0},
        new Ticket {Id = 13, Flight = flights[4], Passenger = passengers[10], SeatNumber = "5C", HasHandLuggage = false, TotalBaggageWeightKg = 14},

        new Ticket {Id = 14, Flight = flights[5], Passenger = passengers[0], SeatNumber = "32A", HasHandLuggage = true, TotalBaggageWeightKg = 5},
        new Ticket {Id = 15, Flight = flights[5], Passenger = passengers[5], SeatNumber = "32B", HasHandLuggage = true, TotalBaggageWeightKg = 8},

        new Ticket {Id = 16, Flight = flights[6], Passenger = passengers[1], SeatNumber = "14E", HasHandLuggage = false, TotalBaggageWeightKg = 0},
        new Ticket {Id = 17, Flight = flights[6], Passenger = passengers[2], SeatNumber = "14F", HasHandLuggage = true, TotalBaggageWeightKg = 15},

        new Ticket {Id = 18, Flight = flights[7], Passenger = passengers[9], SeatNumber = "18D", HasHandLuggage = false, TotalBaggageWeightKg = 0},
        new Ticket {Id = 19, Flight = flights[7], Passenger = passengers[10], SeatNumber = "18C", HasHandLuggage = true, TotalBaggageWeightKg = 9},
        new Ticket {Id = 20, Flight = flights[7], Passenger = passengers[11], SeatNumber = "18A", HasHandLuggage = true, TotalBaggageWeightKg = 11},
        new Ticket {Id = 21, Flight = flights[7], Passenger = passengers[11], SeatNumber = "18E", HasHandLuggage = true, TotalBaggageWeightKg = 16}
        ];
}
using AirCompany.Domain.Entities;
using AirCompany.Domain.DataSeeder;

namespace AirCompany.Tests;

/// <summary>
/// Contains unit tests for air company
/// Uses test data provided by <see cref="DataSeeder"/>
/// </summary>
public class AirCompanyTests(DataSeeder seed) : IClassFixture<DataSeeder>
{
    /// <summary>
    /// Test checks whether the 5 most popular flights are 
    /// displayed correctly based on the number of passengers
    /// </summary>
    [Fact]
    public void GetTop5FlightsByPassengerCount_ShouldReturnFlightsCorrectOrderByPassengerCount()
    {
        var topFlights = seed.Flights
           .Select(f => new
           {
               Flight = f.Code,
               passengerCount = seed.Tickets.Count(t => t.Flight.Id == f.Id)
           })
           .OrderByDescending(x => x.passengerCount)
           .Take(5)
           .ToList();

        // Assert
        Assert.NotNull(topFlights);
        Assert.Equal(5, topFlights.Count);

        for (var i = 0; i < topFlights.Count - 1; i++)
        {
            Assert.True(
                topFlights[i].passengerCount >= topFlights[i + 1].passengerCount,
                $"Порядок нарушен! {topFlights[i].Flight} ({topFlights[i].passengerCount}) < {topFlights[i + 1].Flight} ({topFlights[i + 1].passengerCount})"
            );
        }

        var maxPassengerCount = seed.Flights
            .Max(f => seed.Tickets.Count(t => t.Flight == f));

        Assert.Equal(maxPassengerCount, topFlights[0].passengerCount);
    }

    /// <summary>
    /// Test checks whether the list of flights with the 
    /// minimum travel time is displayed correctly
    /// </summary>
    [Fact]
    public void GetFlightsWithMinimumDuration_ShouldReturnFlightsWithMinimumDuration()
    {
        var minDuration = seed.Flights.Min(f => f.Duration);
        var minDurationFlights = seed.Flights
            .Where(f => f.Duration == minDuration)
            .OrderBy(f => f.DepartureDateTime)
            .ToList();

        //Assert
        Assert.NotEmpty(minDurationFlights);

        Assert.All(minDurationFlights, flight => Assert.Equal(minDuration, flight.Duration));

        for (var i = 0; i < minDurationFlights.Count - 1; i++)
        {
            Assert.True(
                minDurationFlights[i].DepartureDateTime <= minDurationFlights[i + 1].DepartureDateTime,
                $"Flight {minDurationFlights[i].Code} should depart before {minDurationFlights[i + 1].Code}"
            );
        }
    }

    /// <summary>
    /// Test checks whether passengers who did not 
    /// have luggage on a particular flight are returning correctly
    /// </summary>
    [Fact]
    public void GetPassengersWithZeroBaggageByFlight_ShouldReturnPassengersOrderedByName()
    {
        var flight = seed.Flights.First(f => f.Code == "U6713");

        var passengerInfo = seed.Tickets
            .Where(t => t.TotalBaggageWeightKg == 0 && t.Flight.Code == flight.Code)
            .OrderBy(t => t.Passenger.FullName)
            .Select(t => t.Passenger)   
            .ToList();

        //Assert
        Assert.NotEmpty(passengerInfo);

        foreach (var passenger in passengerInfo)
        {
            var passengerTicket = seed.Tickets.First(t => t.Passenger.Id == passenger.Id);
            Assert.Equal(flight.Code, passengerTicket.Flight.Code);
            Assert.Equal(0, passengerTicket.TotalBaggageWeightKg);
        }

        for (var i = 0; i < passengerInfo.Count - 1; i++)
        {
            Assert.True(string.Compare(passengerInfo[i].FullName, passengerInfo[i + 1].FullName) <= 0);
        }

        Console.WriteLine($"Flight {flight.Code}:");  
        Console.WriteLine($"NoBaggage: {passengerInfo.Count}"); 
    }

    /// <summary>
    /// Test checks whether information about all flights of
    /// a certain model aircraft for a specific period is returned correctly
    /// </summary>
    [Fact]
    public void GetFlightsByModelAndPeriod_ShouldReturnFlightsForSelectedModelInPeriod()
    {
        var model = seed.AircraftModels.First(m => m.ModelName.Contains("A320NEO"));
        var startPeriod = new DateTime(2025, 10, 1);
        var endPeriod = new DateTime(2025, 10, 31);

        var flight = seed.Flights
            .Where(f => f.AircraftModel == model && f.DepartureDateTime == startPeriod && f.ArrivalDateTime == endPeriod)
            .ToList();

        Assert.All(flight, f =>
        {
            Assert.Equal(model.Id, f.AircraftModel.Id);
            Assert.InRange(f.DepartureDateTime!.Value, startPeriod, endPeriod);
        });
    }

    /// <summary>
    /// Test checks whether information about all flights 
    /// departing from the specified departure point to 
    /// the specified arrival point is returned correctly
    /// </summary>
    [Fact]
    public void GetFlightsByRoute_ShouldReturnFlightsForSelectedDepartureAndArrival()
    {
        var startAirport = "SVO";
        var endAirport = "JFK";

        var flight = seed.Flights
            .Where(f => f.DepartureAirport == startAirport && f.ArrivalAirport == endAirport)
            .ToList();

        //Assert
        Assert.All(flight, f =>
        {
            Assert.Equal(startAirport, f.DepartureAirport);
            Assert.Equal(endAirport, f.ArrivalAirport);
        });
    }

}
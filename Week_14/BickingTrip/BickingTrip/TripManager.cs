using System;
using System.Collections.Generic;

public class TripManager
{
    private List<Trip> trips;

    public TripManager(List<Trip> trips)
	{
        this.trips = trips;
	}

    public void AddTrip(string destination, double distance, double rating)
    {
        Trip newTrip = new Trip(destination, distance, rating);
        trips.Add(newTrip);
    }

    public void DeleteTrip(int index)
    {
        int tripToDelete = index--;
        trips.RemoveAt(tripToDelete);
    }
    
    public List<Trip> GetTrips()
    {
        return trips;
    }

    public string GetTripInfo(int index)
    {
        Trip searchedTrip = trips[index];
        return searchedTrip.GetInfo();

    }
}

using System;
using System.Collections.Generic;

public class Trip
{
    private string destination;
    private double distance;
    private double rating;

    public Trip(string destination, double distance, double rating)
    {
        this.destination = destination;
        this.distance = distance;
        this.rating = rating;
    }

    public string GetDestination()
    {
        return destination;
    }

    public string GetInfo()
    {
        return $"{destination}: {distance:F2} KM | rating {rating:F2}/5";
    }
}

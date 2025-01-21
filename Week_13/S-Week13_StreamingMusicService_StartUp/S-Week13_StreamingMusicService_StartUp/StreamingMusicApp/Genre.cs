using System;

public class Genre
{
    private string name;
    private string description;
    public Genre(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetDescription()
    {
        return this.description;
    }
    public string GetInfo()
    {
        return $"{this.name} ({this.description})";
    }
}


namespace MauiPrevisaoTempo.Models;

public class WeatherData
{
    public string Name { get; set; }
    public Coord Coord { get; set; }
    public Weather[] Weather { get; set; }
    public string Base { get; set; }
    public Main Main { get; set; }
    public long Visibility { get; set; }
    public Wind Wind { get; set; }
    public Clouds Clouds { get; set; }
    public long Dt { get; set; }
    public Sys Sys { get; set; }
    public long Id { get; set; }
    public long Cod { get; set; }
}


public class Clouds
{
    public long All { get; set; }
}

public class Coord
{
    public double Lon { get; set; }
    public double Lat { get; set; }
}

public class Main
{
    public double Temp { get; set; }
    public long Pressure { get; set; }
    public long Humidity { get; set; }
    public double Temp_Min { get; set; }
    public double Temp_Max { get; set; }
}

public class Sys
{
    public long Type { get; set; }
    public long Id { get; set; }
    public double Message { get; set; }
    public string Country { get; set; }
    public long Sunrise { get; set; }
    public long Sunset { get; set; }
}

public class Weather
{
    public long Id { get; set; }
    public string Visibility { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
}

public class Wind
{
    public double Speed { get; set; }
    public long Deg { get; set; }
}

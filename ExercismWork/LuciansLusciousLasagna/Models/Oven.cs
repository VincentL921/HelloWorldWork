using System;

public class Oven
{
    private List<Food> _foodInOven = new List<Food>();
    private int _timeElapsed = 0;

    public void Add(Food foodItem)
    {
        _foodInOven.Add(foodItem);
    }

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int GetCookTime()
    {
        return _foodInOven.Sum(m => m.CookMinutes);
    }
    public void ExpectedMinutesInOven(int numOfMinutes)
    {
        _timeElapsed = _timeElapsed + numOfMinutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven()
    {
        return GetCookTime() - GetTimeElapsed();
    }
    public int GetTimeElapsed()
    {
        return _timeElapsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int GetLasagnaLayers()
    {
        return _foodInOven.Sum(x => x.LasagnaLayers);
    }

    public int PrepTimeInMinutes(int minPerLayer)
    {
        return GetLasagnaLayers() * minPerLayer;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int GetTotalElapsedTime()
    {
        return RemainingMinutesInOven() + PrepTimeInMinutes(2);
    }
}

public abstract class Activity
{
    private string _date;
    private double _minutes;

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(double minutes)
    {
        _minutes = minutes;
    }

    public Activity(string date, double minutes)
    {
        SetDate(date);
        SetMinutes(minutes);

    }

    public abstract double GetDistance();


    public abstract double GetSpeed();

    public abstract double GetPace();
   

    public abstract string GetActivity();

    public virtual void GetSummary()
    {
        Console.WriteLine($"\n{_date} {GetActivity()} ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/mile");
    }

    
}
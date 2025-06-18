public abstract class Activity{

    private float _duration;
    private string _name;
    
    public Activity(string name, float duration){
        _name = name;
        _duration = duration;
    }

    public abstract float Speed();
    public abstract float Pace();
    public abstract float Distance();

    public float GetDuration(){
        return _duration;
    }


    public virtual string GetSummary(){
        DateTime date = DateTime.Now;
        string  info = $"{date.ToString("dd MMM, yyyy")} {_name} ({_duration} min) - ";
        info += $"Distance {Distance()} kilometers, Speed {Speed()} kph, Pace: {Pace()} min per km";
        return info;   
    }

    
}
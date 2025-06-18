public class Running : Activity {
    
    private int _distance; 

    public Running(string name, float duration, int distance):base(name, duration){
         _distance = distance;
    }

    public override float Speed(){
          return (_distance / GetDuration()) * 60;    
    }

    public override float Pace(){
         return GetDuration() / _distance;
    }

    public override float Distance(){
        return _distance;
    }

     public string ShowSummary(){
        return GetSummary() + $"Distance {Distance()} kilometers, Speed {Speed()} kph, Pace: {Pace()} min per km";
    }
}
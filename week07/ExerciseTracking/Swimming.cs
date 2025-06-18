public class Swimming : Activity {
    
    private int _laps; 

    public Swimming(string name, float duration, int laps):base(name, duration){
         _laps = laps;
    }

    public override float Speed(){
          return  60 / Pace();    
    }

    public override float Pace(){
         return GetDuration() / Distance();
    }

    public override float Distance(){
        return _laps * 50 / 1000;
    }

     public string ShowSummary(){
        return GetSummary() + $"Distance {Distance()} kilometers, Speed {Speed()} kph, Pace: {Pace()} min per km";
    }

}
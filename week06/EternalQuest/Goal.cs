public abstract class Goal {
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string point){
        _name = name; _description = description; _points = point;
    }

    public abstract void RecordEvent();
    public bool IsCommplete(){ return false; }
    public string GetDetailString(){
        return _description;
    }
    public string GetStringRepresentation(){
         return _name;
    }
}
public class Goal {
    private string _name;
    private string _description;
    private string _points;

    public Goal(string name, string description, string point){
        _name = name; _description = description; _points = point;
    }

    public virtual void RecordEvent(){}
    public virtual bool IsCommplete(){ return false; }
    public string GetDetailString(){
        return _description;
    }
    public string GetStringRepresentation(){
         return _name;
    }
}
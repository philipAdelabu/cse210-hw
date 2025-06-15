public abstract class Goal {
    private string _name;
    private string _description;
    private string _points;

 

    public Goal(string name, string description, string point){
        _name = name; _description = description; _points = point;
    }

    public abstract int RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract bool IsComplete();

    public string GetName(){
         return _name;
    } 

    public virtual string GetDetailString(){  return $"{_name} ({_description})"; }
    public string GetPoints(){ return _points; }

    public string GetCSV(){
         return $"{_name},{_description},{_points}"; 
    }
  
    
}
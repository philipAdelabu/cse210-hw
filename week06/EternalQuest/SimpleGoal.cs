public class SimpleGoal : Goal {
     private bool _IsComplete;

     public SimpleGoal(string name, string description, string points) : base(name, description, points){

     }
     public override void RecordEvent(){}
     public bool IsCommplete(){ return false; }
     public string GetStringRepresentation() {
        return "";
     }
}
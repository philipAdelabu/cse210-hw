public class SimpleGoal : Goal {
     private bool _IsComplete;
   

     public SimpleGoal(string name, string description, string points, bool IsCommplete=false) : base(name, description, points){
           _IsComplete = IsCommplete;
     }
     public override int RecordEvent(){
         if(IsComplete()) return 0;
        _IsComplete = true;
        return int.Parse(GetPoints());
     }
     public override bool IsComplete(){ return _IsComplete; }

     public override string GetStringRepresentation() { 
        return "SimpleGoal:" + GetCSV() +","+IsComplete();
     }

 
}
public class EternalGoal : Goal {

      public EternalGoal(string name, string description, string points) : base(name, description, points){

      }

      public override bool IsComplete() { return false; }
      public override string GetStringRepresentation() {
        return "EternalGoal:" + GetCSV();
     }


      public override int RecordEvent(){
            return int.Parse(GetPoints());
     }
}
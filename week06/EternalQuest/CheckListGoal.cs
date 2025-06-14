public class CheckListGoal : Goal {
       
       private int _amountCompleted;
       private int _target;
       private int _bonus;

      public CheckListGoal(string name, string description, string point, int target, int bonus) : base(name, description, point){
          _target = target;
          _bonus = bonus;
      }

      public void RecordEvent(){}
      public bool IsCommplete(){ return false; }
      public string GetDetailString(){ return ""; }
      public string GetStringRepresentation(){
        return "";
      }




}
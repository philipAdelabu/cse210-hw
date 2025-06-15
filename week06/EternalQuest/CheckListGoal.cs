public class CheckListGoal : Goal {
       private int _target;
       private int _bonus;
       private int _counts;
       private int _amountCompleted;
       private string _name;
       private string _description;
    

      public CheckListGoal(string name, string description, string point, int target, int bonus, int counts) : base(name, description, point){
          _target = target;
          _bonus = bonus;
          _counts = counts;
          _amountCompleted = 0;
          _name = name;
          _description = description;
      }

        public override int RecordEvent(){
              if(IsComplete()) return 0;
               _counts += 1;
               int point = int.Parse(GetPoints());
               _amountCompleted += point;
               if(_counts == _target){
                 Console.WriteLine($" **** BONUS OF {_bonus} POINTS ADDED ****");
                  return point + _bonus;
               }
               return point;
     }

      public override bool IsComplete(){ 
        if(_target == _counts)
          return true;
        return false; 
        }
      

    public override string GetStringRepresentation() { 
        return $"CheckListGoal:{GetCSV()},{_bonus}, {_target}, {_counts}";
     }

     public override string GetDetailString(){
      return $"{_name} ({_description}) --- currently completed: {_counts}/{_target}";
     }

     public void SetCounts(int count){
       _counts += count;
     }
     
     public int GetCounts(){
       return _counts;
     }




}
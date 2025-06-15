public class GoalManager {

    private List<Goal> _goals = new List<Goal>();
    private FileManager fileManager = new FileManager();
    private int _scores;

 
    public GoalManager(){
        _scores = 0;
    }


    public void CreateGoal(int type){
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string point = Console.ReadLine();
          try{
          if(type == 1){
           Goal goal = new SimpleGoal(name, description, point);
             _goals.Add(goal);
             fileManager.SaveEvent(goal);  
          }
          if(type == 2){
              Goal goal = new EternalGoal(name, description, point);
             _goals.Add(goal);
             fileManager.SaveEvent(goal);  
          }
          if(type == 3){
               Console.Write("How many times does this goal need to be accomplished for a bonus? ");
               int target = int.Parse(Console.ReadLine());
               Console.Write("What is the bonus for accomplishing it that many times? ");
               int bonus = int.Parse(Console.ReadLine());
               int counts = 0;
               Goal goal = new CheckListGoal(name, description, point, target, bonus, counts);
              _goals.Add(goal);
              fileManager.SaveEvent(goal);  
          }
          }catch(Exception e){
             Console.WriteLine("something went wrong. Goal could not be created. Please run again and make sure you enter the correct information.");
             return ;
          }      
    }
    public void RecordEvents(){
        Console.WriteLine("");
        int counter = 1;
        if(_goals == null) return ;
        List<Goal> availableGoals = new List<Goal>();
         foreach(Goal goal in _goals){
            string name = goal.GetName();
            if(!goal.IsComplete()){
                Console.WriteLine($"{counter++}. {name}");
                availableGoals.Add(goal);
            }
         }
         Console.Write("Which goal did you accomplish? ");
         int option = int.Parse(Console.ReadLine());
         if(option > 0 && option <= availableGoals.Count){
           int points = availableGoals[option-1].RecordEvent();
           _scores += points;
           fileManager.SaveEvent(availableGoals[option-1]);
            Console.WriteLine($"Congratulations! You have earned a {points} points!");
            Console.WriteLine($"Now you have {_scores} points.");
         }
    }

    public void SaveGoals(){
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        fileManager.SaveToFile(filename, _goals, _scores);  
    }
    public void LoadGoals(){
       Console.Write("From which file do you want to load? ");
        string filename = Console.ReadLine();
      _goals =  fileManager.GetAllGoals(filename);
      _scores = fileManager.GetScores();
      Console.WriteLine("file loaded..");
    }


    public void ListGoals(){
        Console.WriteLine("");
        int counter = 1;
        if(_goals == null) return;
         foreach(Goal goal in _goals){
            string details = goal.GetDetailString();
            if(goal.IsComplete())
                Console.WriteLine($"{counter++}. [x] {details}");
            else 
               Console.WriteLine($"{counter++}. [ ] {details}");
         }
    }

    public void ListEvent(){
         fileManager.ListEvent("events.txt");
    }

        public void start(){
        int option = Menu();
        while(option != 7){
        switch(option){
            case 1: 
               int opt = GoalOptions();
               CreateGoal(opt);
             break;
            case 2:
              ListGoals();
            break;
            case 3:
              SaveGoals();
            break;
            case 4:
              LoadGoals();
              break;
            case 5:
               RecordEvents();
            break;
            case 6:
               ListEvent();
               break;
             case 7:
             return;
            }
            option = Menu();
        }

    }

     private int Menu(){
      Console.WriteLine($"\nYou have {_scores} points\n");
      Console.WriteLine("Menu Options:");
      Console.WriteLine("\t 1. Create New Goal");
      Console.WriteLine("\t 2. List Goals");
      Console.WriteLine("\t 3. Save Goals");
      Console.WriteLine("\t 4. Load Goals");
      Console.WriteLine("\t 5. Record Event");
      Console.WriteLine("\t 6. List Events");
      Console.WriteLine("\t 7. Quit");
      Console.Write("Select an option from the menu: ");
      int option;
      try{
       option = int.Parse(Console.ReadLine());
      while(option > 7 || option < 1){
         Console.WriteLine("You entered the wrong option.");
          Console.Write("Select an option from the menu: ");
     
          option = int.Parse(Console.ReadLine());
      }
        }catch(Exception e){
             Console.WriteLine("You enter the wrong choice.");
             return 7;
     }
      return option;  
    }

    private int GoalOptions(){
          Console.WriteLine("Types of Goal are:");
      Console.WriteLine("\t 1. Simple Goal");
      Console.WriteLine("\t 2. Eternal Goals");
      Console.WriteLine("\t 3. CheckList Goals");
   
      Console.Write("Which type of goal would you like to create: ");
      int option;
      try{
      option = int.Parse(Console.ReadLine());
      while(option > 3 || option < 1){
         Console.WriteLine("You entered the wrong option.");
          Console.Write("try again: ");
          option = int.Parse(Console.ReadLine());
      }
      }catch(Exception e){
         Console.WriteLine("You have entered the wrong choice.");
         return 7;
      }
      return option;
    }




}
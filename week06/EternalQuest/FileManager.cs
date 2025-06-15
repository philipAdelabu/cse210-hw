using System;
using System.IO;

public class FileManager {
      
     private List<Goal> _goals = new List<Goal>();
     private int _scores;
     private Files files = new Files();
     public FileManager(){
         _scores = 0;
     }

      public string SaveToFile(string file_, List<Goal> goals, int scores){
        string file = file_.Trim();
        using(StreamWriter writer = new StreamWriter(file)){
             writer.WriteLine(scores);
            foreach(Goal goal in goals)
              writer.WriteLine(goal.GetStringRepresentation());   
        }
          if(!files.GetFileList().Contains(file))
               files.SaveFileToList(file);

        return $"{file_} saved successfully";
    }

    public List<Goal> LoadFromFile(string file){
        if(!File.Exists(file)) return null ;
        string[] lines = File.ReadAllLines(file);
        if(lines.Length < 1 || lines[0].Trim() == "") return null;
        _scores = int.Parse(lines[0]);
        foreach(string line in lines.Skip(1)){
            string[] parts = line.Split(":");
            string goalType = parts[0]; 
            string[] detailPart = (parts[1]).Split(",");
            string name  = detailPart[0];
            string description = detailPart[1];
            string points = detailPart[2];
            if(goalType == "CheckListGoal"){
               int bonus = int.Parse(detailPart[3]);
               int target = int.Parse(detailPart[4]);
               int counts = int.Parse(detailPart[5]);
              _goals.Add(new CheckListGoal(name, description, points, target, bonus, counts));
            }else if(goalType == "SimpleGoal"){
                 bool IsCommplete = false;
                 if((detailPart[3]).ToLower() == "true") IsCommplete = true;
                 _goals.Add(new SimpleGoal(name, description, points, IsCommplete));
            }else{
                _goals.Add(new EternalGoal(name, description, points));
            }
         
        }
        return _goals;
    }

    public int GetScores() { return _scores; }

    public List<Goal> GetAllGoals(string filename){ 
        return LoadFromFile(filename);
    }

      public void SaveEvent(Goal goal, string filename="events.txt"){
         DateTime now = DateTime.Now;
        string date = now.ToString("yyyy/MM/dd HH.mm.ss");
        using(StreamWriter writer = new StreamWriter(filename, true)){
              writer.WriteLine($"{date}:{goal.GetStringRepresentation()}");   
        }
        return;
    }


     public void ListEvent(string file="events.txt"){
        if(!File.Exists(file)) return ;
        string[] lines = File.ReadAllLines(file);
        if(lines.Length < 1) return;
        foreach(string line in lines){
            string[] parts = line.Split(":");
            if(parts.Length <= 2) 
               continue;
            Console.Write(parts[0]+": ["+parts[1]+"]: "); 
            string remaining = parts[2];
            string[] detailPart = remaining.Split(",");
            foreach(string pt in detailPart){
               Console.Write(pt+", ");
            }Console.WriteLine(".");         
        }
     }
    
}
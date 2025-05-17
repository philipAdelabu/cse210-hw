using System.IO;

public class Journal {

   private string _filename = "";

    private List<Entry> _entries = new List<Entry>();
    Files files = new Files();

    public void AddEntry(Entry entry){
        _entries.Add(entry);
        return;
    }

    public void DisplayAll(){
         foreach(Entry entry in _entries){
              entry.Display();  
         }
    }

    public void SaveToFile(string file_){
        string file = file_.Trim();
        using(StreamWriter writer = new StreamWriter(file, true)){
            foreach(Entry entry in _entries)
              writer.WriteLine($"{entry._promptText}|{entry._entryText}|{entry._date}");   
        }
          if(!files.GetFileList().Contains(file))
               files.SaveFileToList(file);
        return;
    }
    public void LoadFromFile(string file){
        if(!File.Exists(file)) return ;
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines){
            string[] parts = line.Split("|");
            string prompt = parts[0]; 
            string response = parts[1];
            string date = parts[2];
            Entry entry = new Entry(prompt, response, date);
            _entries.Add(entry);
        }
        return;
    }
}

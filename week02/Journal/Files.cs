using System;
using System.IO;


public class Files {

    private List<string> _files = new List<string>();
    private const string _filesList = "filesList.txt";
    public List<string> GetFileList(){
        return _files;
    }

    public bool CreateFile(string filename_){
        string filename = filename_.Trim();
        if(!_files.Contains(filename)){
                using(StreamWriter writer = new StreamWriter(filename, true)){
            writer.Write("");
            SaveFileToList(filename);
            if(!fileExists(filename))
                SaveToFiles(filename);
          }
          return true;
        }  
        return false;
    }

    public void ShowAllFiles(){
        LoadAllFiles();
         if(_files.Count > 0)
         foreach(string file in _files){
            Console.WriteLine(file);
         }
         else Console.WriteLine("There is no file name to display.");
    } 

    public void SaveFileToList(string filename){
         _files.Add(filename);
    }

      public void SaveToFiles(string filename, string file_ = _filesList){
        using(StreamWriter writer = new StreamWriter(file_, true)){
              writer.WriteLine(filename);   
        }
        return;
    }
  
   public bool fileExists(string file, string file_ = _filesList){
         string[] lines = File.ReadAllLines(file_);
        foreach(string line in lines){
             if(file == line) return true;
        }
        return false;
   }

   public bool DeleteFile(string filename_){
           filename_ = filename_.Trim();
           if(filename_ == "filesList.txt") return false;
           if(filename_.EndsWith(".txt") || filename_.EndsWith(".csv") || filename_.EndsWith(".json"))
            if(File.Exists(filename_)){
                File.Delete(filename_);
                return true;
            }
        return false;
   }

  public void LoadAllFiles(){
      string[] lines = File.ReadAllLines("filesList.txt");
        foreach(string line in lines){
            if(_files.Contains(line)) 
               continue;
            _files.Add(line);
        }
        return;
  } 

}

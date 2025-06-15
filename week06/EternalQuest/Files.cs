using System;
using System.IO;


public class Files {

    private List<string> _files = new List<string>();
    private const string _filesList = "filesList.txt";
    
    public List<string> GetFileList(){
        return _files;
    }

    public Files(){
        LoadAllFiles();
    }

    public bool CreateFile(string filename_){
        string filename = filename_.Trim();
        if(!_files.Contains(filename)){
                using(StreamWriter writer = new StreamWriter(filename, true)){
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

   public bool DeleteFile(string filename_, string file_ = _filesList){
           filename_ = filename_.Trim();
           if(filename_ == "filesList.txt") return false;
           if(filename_.EndsWith(".txt") || filename_.EndsWith(".csv") || filename_.EndsWith(".json"))
            if(File.Exists(filename_)){
                    File.Delete(filename_);
                   _files.Remove(filename_);
                    using(StreamWriter writer = new StreamWriter(file_)){
                        foreach(string filename in _files)
                          writer.WriteLine(filename);   
                  }
                return true;
            }else if(_files.Contains(filename_)){
                    _files.Remove(filename_);
                    using(StreamWriter writer = new StreamWriter(file_)){
                        foreach(string filename in _files)
                          writer.WriteLine(filename);   
                  }
            }
        return false;
   }

  public void LoadAllFiles(){
    string file_name = "filesList.txt";
    if(!File.Exists(file_name)){
       using(StreamWriter writer = new StreamWriter(file_name, true)){
       }
    }
      string[] lines = File.ReadAllLines(file_name);
        foreach(string line in lines){
            if(_files.Contains(line)) 
               continue;
            _files.Add(line);
        }
        return;
  } 

}

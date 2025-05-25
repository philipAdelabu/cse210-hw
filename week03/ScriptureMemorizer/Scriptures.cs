using System;
using System.IO;

public class Scriptures {
   private List<Scripture> _scriptures = new List<Scripture>();
   private Reference _reference;

    public Scriptures(){
     LoadAllScriptures();
    }

    // "Verse ID -> 0","Book Name -> 1","Book Number -> 2",Chapter -> 3,Verse -> 4,Text -> 5
    //"Verse ID","Book Name","Book Number",Chapter,Verse,Text

     public void LoadAllScriptures(){
      
        using (StreamReader sr = new StreamReader("kjv.csv"))
            {
               while (!sr.EndOfStream)
               {
               string line = sr.ReadLine();
               string[] src = line.Split(',');
                    string  tx = string.Join(", ", src[5..]); 
                    Reference reference = new Reference(src[1], int.Parse(src[3]), int.Parse(src[4]));
                   _scriptures.Add(new Scripture(reference, tx));
               }
            }
            return ;
  }

  public List<Scripture> GetSricptures() { 
     return _scriptures;
  }


}

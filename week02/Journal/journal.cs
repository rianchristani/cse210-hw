public class Journal{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry (Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries){
            Console.WriteLine(entry._promptText);
        }
    }

    public void SaveToFile(string file){

    }

    public void LoadFromFile(string file){

    }
}
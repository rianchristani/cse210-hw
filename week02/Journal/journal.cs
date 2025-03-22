public class Journal{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry (Entry newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveToFile(string filename){
        using (StreamWriter outputFile = new StreamWriter ($"{filename}.csv", true))
            {
                foreach (Entry line in _entries){
                    outputFile.WriteLine($"{line._date},{line._promptText},{line._entryText}");
                }
            }
    }

    public void LoadFromFile(string filename){
            string [] lines = System.IO.File.ReadAllLines ($"{filename}.csv");
            _entries.Clear();

            foreach (string line in lines)
            {
                string [] parts = line.Split(",");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];

                AddEntry(entry);
            } 

    }
}
public class Scripture{
    private Reference _reference;

    private List<Word>_words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" ")){
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide){
        Random random = new Random();
        int counter = 0;

        while (counter != numberToHide){
            int irandom = random.Next(_words.Count);
            if (_words[irandom].isHidden() == false){
            _words[irandom].Hide();
            counter++;
            }
        }
    }

    public void GetDisplayText(){

        string displayText = "";

        foreach (Word word in _words){
            displayText += word.GetDisplayText() + " ";
        }
        Console.WriteLine(displayText);
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (word.isHidden() == false){
                return false;
            }
        }
        return true;
        }

    }


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

        for (int i = 0; i < numberToHide && i < _words.Count; i++){
            _words[i].Hide();
        }
    }

    public void GetDisplayText(){
        _words.Clear();

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


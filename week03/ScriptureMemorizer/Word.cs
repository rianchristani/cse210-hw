using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Word{
    private string _text;

    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
    }

    public void Show(){
        _isHidden = false;

    }

    public bool isHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        if (isHidden() == true){
            string result = ""; 
            foreach (char c in _text){
                result += "_";
            }
            return result;
        }
        else{
            return _text;
        }
    }
}
using System;
using System.Runtime.CompilerServices;

public class display{
    public List<write>_sentences = new List<write>();

    public void Display(){

    foreach (write phrase in _sentences){
        phrase.Display();
    }
}
}
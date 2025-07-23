using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Scripture display = new Scripture();
        Word word1 = new Word();
        //display.SetScriptureQuote();
        //Reference reff = new Reference();
        //display.GetScriptureQuote();
        display.HideRandomWords();
        word1.SetWordToHide();



        //reff.GetReference();
    }
}
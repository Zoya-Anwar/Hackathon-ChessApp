using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System;

public class speechToText{
    static ManualResetEvent _completed = null;
    public speechToText()
    {
        
        _completed = new ManualResetEvent(false);
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();

        Choices choices = new Choices("a1", "a2", "a3", "a4", "a5", "a6", "a7", "a8",
                                      "b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8",
                                      "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8",
                                      "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8",
                                      "e1", "e2", "e3", "e4", "e5", "e6", "e7", "e8",
                                      "f1", "f2", "f3", "f4", "f5", "f6", "f7", "f8",
                                      "g1", "g2", "g3", "g4", "g5", "g6", "g7", "g8",
                                      "h1", "h2", "h3", "h4", "h5", "h6", "h7", "h8");
        GrammarBuilder moveChoiceBuilder = new GrammarBuilder(choices);
        _recognizer.LoadGrammar(new Grammar(moveChoiceBuilder)); // load a grammar
        _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("hint"))); // load a grammar
        _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("exit"))); // load a "exit" grammar
        _recognizer.SpeechRecognized += _recognizer_SpeechRecognized; 
      //  _recognizer.SpeechRecognitonRejected += _recognizer_SpeechRecognitionRejected;
        _recognizer.SetInputToDefaultAudioDevice(); // set the input of the speech recognizer to the default audio device
        _recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous
        _completed.WaitOne(); // wait until speech recognition is completed
        _recognizer.Dispose(); // dispose the speech recognition engine
        
    }

    public void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        //  if (e.Result.Text == "test") // e.Result.Text contains the recognized text
        // {
        //     Console.WriteLine("The test was successful!");
        // } 
        // else if (e.Result.Text == "exit")
        // {
        //     _completed.Set();
        // }
        switch (e.Result.Text)
        {
            case "a1": case "a2": case "a3": case "a4": case "a5": case "a6": case "a7": case "a8":
            case "b1": case "b2": case "b3": case "b4": case "b5": case "b6": case "b7": case "b8":
            case "c1": case "c2": case "c3": case "c4": case "c5": case "c6": case "c7": case "c8":
            case "d1": case "d2": case "d3": case "d4": case "d5": case "d6": case "d7": case "d8":
            case "e1": case "e2": case "e3": case "e4": case "e5": case "e6": case "e7": case "e8":
            case "f1": case "f2": case "f3": case "f4": case "f5": case "f6": case "f7": case "f8":
            case "g1": case "g2": case "g3": case "g4": case "g5": case "g6": case "g7": case "g8":
            case "h1": case "h2": case "h3": case "h4": case "h5": case "h6": case "h7": case "h8":
                 Console.WriteLine(e.Result.Text);
                break;
            case "hint":
                Console.WriteLine("You will recieve a hint!");
                break;
            case "exit":
                _completed.Set();
                break;
        }

    } 
    public void _recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
    {
        if (e.Result.Alternates.Count == 0)
        {
            Console.WriteLine("Speech rejected. No candidate phrases found.");
            return;
        }
        Console.WriteLine("Speech rejected. Did you mean:");
        foreach (RecognizedPhrase r in e.Result.Alternates)
        {
            Console.WriteLine("    " + r.Text);
        }
    }

}

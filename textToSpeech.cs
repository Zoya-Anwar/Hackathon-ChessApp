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
        _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("test"))); // load a grammar
        _recognizer.LoadGrammar(new Grammar(new GrammarBuilder("exit"))); // load a "exit" grammar
        _recognizer.SpeechRecognized += _recognizer_SpeechRecognized; 
     //   _recognizer.SpeechRecognitonRejected += _recognizer_SpeechRecognitionRejected;
        _recognizer.SetInputToDefaultAudioDevice(); // set the input of the speech recognizer to the default audio device
        _recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous
        _completed.WaitOne(); // wait until speech recognition is completed
        _recognizer.Dispose(); // dispose the speech recognition engine
        
    }

    public void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
        if (e.Result.Text == "test") // e.Result.Text contains the recognized text
        {
            Console.WriteLine("The test was successful!");
        } 
        else if (e.Result.Text == "exit")
        {
            _completed.Set();
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

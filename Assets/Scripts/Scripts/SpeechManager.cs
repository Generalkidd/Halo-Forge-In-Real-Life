using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    // Use this for initialization
    void Start()
    {
        keywords.Add("Increase", () =>
        {
            // Call the OnReset method on every descendant object.
            this.BroadcastMessage("Increase");
        });

        keywords.Add("Decrease", () =>
        {
            // Call the OnDrop method on just the focused object.
            this.BroadcastMessage("Decrease");
        });

        keywords.Add("Next", () =>
        {
            this.BroadcastMessage("Next");
        });

        keywords.Add("Submit", () =>
        {
            this.BroadcastMessage("Submit");
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
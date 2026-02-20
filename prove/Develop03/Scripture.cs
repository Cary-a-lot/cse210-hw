using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = new List<Word>();
        string[] parts = text.Split(' ');
        foreach (string w in parts)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        List<string> parts = new List<string>();
        foreach (Word w in _words)
        {
            parts.Add(w.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", parts)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
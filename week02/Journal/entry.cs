using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _text;
    private string _mood;

    public Entry(string date, string prompt, string text, string mood)
    {
        _date = date;
        _prompt = prompt;
        _text = text;
        _mood = mood;
    }

    public string GetDisplayEntry()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nMood: {_mood}\nEntry: {_text}\n";
    }

    public string GetSaveFormat()
    {
        return $"{_date}|{_prompt}|{_text}|{_mood}";
    }

    public static Entry FromSaveFormat(string line)
    {
        string[] parts = line.Split("|");

        if (parts.Length < 4)
            return null;

        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}
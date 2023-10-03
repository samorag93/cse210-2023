using System;

public class MathAssignment : Assignents
{
    private string _textbook;
    private string _example;

    public MathAssignment(string studentName, string topic, string textbook, string example) : base(studentName,topic)
    {
        _textbook = textbook;
        _example = example;
    }

    public string GetHomework()
    {
        return $"Section {_textbook} - Problems {_example}";
    }
}
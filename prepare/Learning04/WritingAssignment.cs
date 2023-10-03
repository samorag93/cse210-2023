using System;

public class WritingAssignment : Assignents
{
    private string _list;

    public WritingAssignment(string studentName, string topic, string list) : base(studentName, topic)
    {
        _list = list;
    }

    public string GetList()
    {
        string studentName = GetStudentName();
        return $"{_list} by {studentName} ";
    }
}
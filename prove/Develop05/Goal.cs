using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool isComplete();
    public abstract string GetStringRepresentation();

    public string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
}

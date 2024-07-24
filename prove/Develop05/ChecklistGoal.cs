public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (isComplete())
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

    public string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_amountCompleted}/{_target} times completed";
    }
}

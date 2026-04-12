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

    public void SetAmountCompleted(int completed)
    {
        _amountCompleted = completed;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            int points = GetPoints();
            Console.WriteLine($"You got a bonus of {_bonus} points!");
            points += _bonus;
            SetPoints(points);
        }
        else if (_amountCompleted > _target)
        
        {
            Console.WriteLine("\nYou already completed this goal. Time to set a new one!");
            SetPoints(0);
            _amountCompleted--;
        }

    }

    public override bool IsComplete()
    // Returns true if the user completed the goal the target number of times
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        if (IsComplete())
        {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal/{GetName()}/{GetDescription()}/{GetPoints()}/{_bonus}/{_target}/{_amountCompleted}";
    }
}
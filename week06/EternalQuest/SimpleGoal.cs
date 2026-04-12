public class SimpleGoal : Goal
{
    private bool _isComplete;


    public bool GetComplete()
    {
        return _isComplete;
    }


    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()

    {
        return $"Simple Goal::{GetName()}::{GetDescription()}::{GetPoints()}::{_isComplete}";
    }
}
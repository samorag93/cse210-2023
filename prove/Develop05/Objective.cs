public class Objective
{
    public string Name { get; set; }
    public string Description {get; set;}
    public bool IsCompleted { get; set; }

    public Objective(string name, string description)
    {
        Name = name;
        Description = description;
        IsCompleted = false;
    }

    public virtual int GetReward()
    {
        return 0;
    }

    public virtual void CompleteObjective()
    {
        IsCompleted = true;
    }
}

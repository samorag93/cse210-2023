public class ChecklistObjective : Objective
{
    public int RewardPerCompletion { get; }
    public int TargetCount { get; }
    public int SubgoalsCompleted { get; set; }
    public int TotalSubgoals { get; set; }
    private int completionCount = 0;
    private int points;
    private int[] ints;

    public ChecklistObjective(string name,string description, int rewardPerCompletion, int targetCount) : base(name, description)
    {
        RewardPerCompletion = rewardPerCompletion;
        TargetCount = targetCount;
    }

    public ChecklistObjective(string name, string description, int points, int[] ints, int totalSubgoals) : base(name, description)
    {
        this.points = points;
        this.ints = ints;
        TotalSubgoals = totalSubgoals;
        SubgoalsCompleted = 0;
    }

    public ChecklistObjective(string name, string description, int points, int[] ints) : base(name, description)
    {
    }

    public override int GetReward()
    {
        return completionCount * RewardPerCompletion;
    }

    public override void CompleteObjective()
    {
        if (completionCount < TargetCount)
        {
            completionCount++;
            IsCompleted = completionCount == TargetCount;
        }
        SubgoalsCompleted++;
        if (CompletedCount >= TargetCount)
        {
            base.CompleteObjective();
        }
    }
    public int CompletedCount { get; private set; }

    public void MarkCompleted()
    {
        completionCount++;
    }
}

public class EternalObjective : Objective
{
    public EternalObjective(string name, string description, int rewardPerCompletion) : base(name, description)
    {
        RewardPerCompletion = rewardPerCompletion;
    }

    public int RewardPerCompletion { get; private set; }
    
    public override int GetReward()
    {
        return IsCompleted ? RewardPerCompletion : 0;
    }
}

public class SimpleObjective : Objective
{
    public int Reward { get; }

    public SimpleObjective(string name, string description, int reward) : base(name, description)
    {
        Reward = reward;
    }

    public override int GetReward()
    {
        return IsCompleted ? Reward : 0;
    }
}

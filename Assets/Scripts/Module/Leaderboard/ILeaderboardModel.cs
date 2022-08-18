using Agate.MVC.Base;

public interface ILeaderboardModel : IBaseModel
{
    public int[] Scores { get; }
    public string[] Names { get; }
}

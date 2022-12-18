public class Team
{
    public Team()
    {

    }
    public Team(string teamName, List<Player> players)
    {
        TeamName = teamName;
        Players = players;
    }
    public int Id { get; set; }
    public string TeamName { get; set; }
    public int Score { get; set; }
    public List<Player> Players { get; set; } = new List<Player>();
}
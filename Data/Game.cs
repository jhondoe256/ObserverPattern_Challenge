
public class Game
{
    public Game()
    {

    }
    public Game(Team homeTeam, Team awayTeam)
    {
        HomeTeam = homeTeam;
        AwayTeam = awayTeam;
    }

    public Team HomeTeam { get; set; }
    public Team AwayTeam { get; set; }
}

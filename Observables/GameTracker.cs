
public class GameTracker : IObserver
{
    private ScoreKeeper _scoreKeeper;
    private TeamRepository _teamRepo;
    private Player _player;
    private int _pointsScored;

    public GameTracker(ScoreKeeper scoreKeeper, Player player, TeamRepository teamRepo)
    {
        _scoreKeeper = scoreKeeper;
        _player = player;
        _teamRepo = teamRepo;
    }

    public GameTracker(ScoreKeeper scoreKeeper, TeamRepository teamRepo)
    {
        _scoreKeeper = scoreKeeper;

        _teamRepo = teamRepo;
    }

    public int PointsScored
    {
        get => _pointsScored;
        set
        {
            _pointsScored = value;
            //value = 0;
        }
    }
    public Player Player { get => _player; set => _player = value; }

    public void Update()
    {
        var team = GetTeamInfo(_player);
        team.Score += PointsScored;
        System.Console.WriteLine($"{team.TeamName} - {team.Score}" + "\n" + "------------------------------\n");
    }

    private Team GetTeamInfo(Player player)
    {
        return _teamRepo.GetTeams().SingleOrDefault(t => t.Players.Contains(player));
    }
}

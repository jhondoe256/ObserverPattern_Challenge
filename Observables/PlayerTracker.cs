
public class PlayerTracker : IObserver
{
    private ScoreKeeper _scoreKeeper;
    private int _pointsScored;
    private Player _player;
    public PlayerTracker(ScoreKeeper scoreKeeper, Player player)
    {
        _scoreKeeper = scoreKeeper;

        _player = player;
    }

    public int PointsScored { get => _pointsScored; set => _pointsScored = value; }

    public void Update()
    {
        UpdatePlayerStats();
        
    }

    private void UpdatePlayerStats()
    {
        _player.Points += PointsScored;
        System.Console.WriteLine($"{_player.Name} - {_player.Points}");
        
    }
}


public class PlayerRepository
{
    private List<Player> _players = new List<Player>();
    private int _count;

    public PlayerRepository()
    {
        Seed();
    }

    public bool AddPlayer(Player player) => (player != null) ? AddToDb(player) : false;

    private bool AddToDb(Player player)
    {
        player.Id = AssignId();
        _players.Add(player);
        return true;
    }

    private int AssignId()
    {
        return ++_count;
    }

    public Player GetPlayer(int id) => _players.FirstOrDefault(x => x.Id == id);

    private void Seed()
    {
        var playerA = new Player()
        {
            Number = 23,
            Name = "Michael Jordan"
        };
        var playerB = new Player()
        {
            Number = 33,
            Name = "Scottie Pippen"
        };

        var playerC = new Player()
        {
            Number = 33,
            Name = "Patric Ewing"
        };
        var playerD = new Player()
        {
            Number = 03,
            Name = "John Starks"
        };

        AddPlayer(playerA);
        AddPlayer(playerB);
        AddPlayer(playerC);
        AddPlayer(playerD);
    }

}

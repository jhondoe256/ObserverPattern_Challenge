
public class TeamRepository
{
    private PlayerRepository _playerRepo;
    private List<Team> _teams = new List<Team>();
    private int _count;

    public TeamRepository(PlayerRepository playerRepository)
    {
        _playerRepo = playerRepository;
        Seed();
    }
    public bool AddTeam(Team team) => (team != null) ? AddToDb(team) : false;
    public Team GetTeam(int id) => _teams.FirstOrDefault(x => x.Id == id);
    public List<Team> GetTeams() => _teams;

    private bool AddToDb(Team team)
    {
        team.Id = AssignId();
        _teams.Add(team);
        return true;
    }

    private int AssignId()
    {
        return ++_count;
    }

    private void Seed()
    {
        var teamA = new Team("The Bulls", new List<Player>
        {
            _playerRepo.GetPlayer(1),
            _playerRepo.GetPlayer(2)
        });

        var teamB = new Team("The Nicks", new List<Player>
        {
            _playerRepo.GetPlayer(3),
            _playerRepo.GetPlayer(4)
        });

        AddTeam(teamA);
        AddTeam(teamB);
    }
}

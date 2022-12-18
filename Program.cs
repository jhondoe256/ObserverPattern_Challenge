Console.Clear();

var playerRepository = new PlayerRepository();
var mJ = playerRepository.GetPlayer(1);
var sP = playerRepository.GetPlayer(2);
var pE = playerRepository.GetPlayer(3);
var jS = playerRepository.GetPlayer(4);

var teamRepository = new TeamRepository(playerRepository);

//Game -> has two teams
var homeTeam = teamRepository.GetTeam(1);
var awayTeam = teamRepository.GetTeam(2);

var game = new Game(homeTeam, awayTeam);

var scoreKeeper = new ScoreKeeper();
scoreKeeper.Game = game;

var gameTracker = new GameTracker(scoreKeeper, teamRepository);

var mJordanTracker = new PlayerTracker(scoreKeeper, mJ);
var sPippenTracker = new PlayerTracker(scoreKeeper, sP);
var pEwingTracker = new PlayerTracker(scoreKeeper, pE);
var jStarksTracker = new PlayerTracker(scoreKeeper, jS);

GameSinario(mJ, mJordanTracker, 3);
scoreKeeper.AddObserver(mJordanTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();


GameSinario(sP, sPippenTracker, 2);
scoreKeeper.AddObserver(sPippenTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

GameSinario(sP, sPippenTracker, 3);
scoreKeeper.AddObserver(sPippenTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

System.Console.WriteLine();
System.Console.WriteLine(mJ);
System.Console.WriteLine(sP);

GameSinario(pE, pEwingTracker, 3);
scoreKeeper.AddObserver(pEwingTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

GameSinario(jS, jStarksTracker, 3);
scoreKeeper.AddObserver(jStarksTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

GameSinario(jS, jStarksTracker, 3);
scoreKeeper.AddObserver(jStarksTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

GameSinario(jS, jStarksTracker, 3);
scoreKeeper.AddObserver(jStarksTracker);
scoreKeeper.AddObserver(gameTracker);
scoreKeeper.NotifiyObservers();

System.Console.WriteLine(jS);
System.Console.WriteLine(pE);

System.Console.WriteLine($"Home: {homeTeam.Score} - Away:{awayTeam.Score}");

void GameSinario(Player player, PlayerTracker playerTracker, int score)
{
    if (gameTracker != null)
    {
        gameTracker.Player = player;
        playerTracker.PointsScored = score;
        gameTracker.PointsScored = score;
    }
}
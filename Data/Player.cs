public class Player
{
    public int Id { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }
    public int Points { get; set; }

    public override string ToString()
    {
        var str = "Player:{" + "\n";
        str += $"Number: {Number}" + "\n";
        str += $"Name: {Name}" + "\n";
        str += $"Points: {Points}" + "\n";
        str += "}" + "\n";
        str += "------------------------------------" + "\n";
        return str;
    }
}
namespace Uno;

public class UnoGame
{
    public List<Player> Players { get; set; } = new();
    public List<Card> DrawStack { get; set; } = new();
    public List<Card> DiscardStack { get; set; } = new();

    public Color CurrentColor { get; set; }
}
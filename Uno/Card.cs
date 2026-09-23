namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{

    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }

    public static bool PlaysOn(Card card1, Card card2, Color? currentColor = null)
    {
        if (card1.Type == CardType.Wild || card1.Type == CardType.WildDraw4)
        {
            return true;
        }
        else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
        {
            return currentColor == null || card1.Color == currentColor;
        }
    
        else if (card1.Type == CardType.Number && card2.Type == CardType.Number && card1.Number == card2.Number)
        {
            return true;
        }
        else if (card1.Color == card2.Color)
        {
            return true;
        }
        else if (card1.Type == card2.Type && card1.Type != CardType.Number)
        {
            return true;

        }

        return false;
    }
    public override string ToString()
    {
        //TODO handle other card types
        if (Type == CardType.Number)
        {
            return $"{Color} {Number}";
        }
        if (Type == CardType.Wild || Type == CardType.WildDraw4)
        {
            return $"{Type}";
        }
        else
        {
            return $"{Color} {Type}";
        }   
    }
}
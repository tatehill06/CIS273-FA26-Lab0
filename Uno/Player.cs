using System.Globalization;

namespace Uno;

public class Player
{
    public string Name { get; set; }

    public List<Card> Hand { get; set; } = new();

    public bool HasPlayableCard(Card card)
    {
        foreach (Card card1 in Hand)
        {
            if (Card.PlaysOn(card1, card))
            {
                return true;
            }  
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (Card card1 in Hand)
        {
            if (Card.PlaysOn(card1, card))
            {
                return card1;
            }  
        }
        return null;
    }

    public Color MostCommonColor()
    {
        int red = 0;
        int yellow = 0;
        int blue = 0;
        int green = 0;

        foreach (Card card in Hand)
        {
            if(card.Color == Color.Red)
                red++;
            else if(card.Color == Color.Yellow)
                yellow++;
            else if(card.Color == Color.Blue)
                blue++;
            else if(card.Color == Color.Green)
                green++;
        }
        int[] cardcount = { red, yellow, blue, green };
        int mostcommon = 0;

        for(int i = 1; i < cardcount.Length; i++)
        {
            if(cardcount[i] > cardcount[mostcommon])
            {
                mostcommon = cardcount[i];
            }
        }
        return (Color)mostcommon;
    }
}
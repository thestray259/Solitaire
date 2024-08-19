using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // front image
    // back image

    public enum Suit 
    { 
        Spades = 1, 
        Hearts = 2, 
        Diamonds = 3, 
        Clubs = 4 
    }

    public enum Number
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Jack = 10,
        Queen = 11,
        King = 12
    }

    public Suit suit;
    public Number num;

    public Card(Suit sut, Number number)
    {
        suit = sut;
        num = number;
    }
}

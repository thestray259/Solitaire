using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    private void Start()
    {
        foreach (var suit in Enum.GetValues(typeof(Card.Suit)))
        {
            foreach (var num in Enum.GetValues(typeof(Card.Number)))
            {
                deck.Add(new Card((Card.Suit)suit, (Card.Number)num));
            }
        }

        foreach (var card in deck)
        {
            Debug.Log("Card: " + card.num + " of " + card.suit);
        }
    }

    public Card[] ShuffleDeck(Card[] deck)
    {
        // shuffle cards in deck, then return shuffled deck
        return deck;
    }

    public void Deal(Card[] deck)
    {
        // deal out the cards on the board
    }
}

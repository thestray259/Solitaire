using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    private void Start()
    {
        var deck = GenerateDeck();
        ShuffleDeck(deck);

        foreach (var card in deck)
        {
            Debug.Log("Card " + card.num + " of " + card.suit);
        }
    }

    public static List<Card> GenerateDeck()
    {
        var cards = new List<Card>();
        foreach (var suit in Enum.GetValues(typeof(Card.Suit)))
        {
            foreach (var num in Enum.GetValues(typeof(Card.Number)))
            {
                cards.Add(new Card((Card.Suit)suit, (Card.Number)num));
            }
        }

/*        foreach (var card in cards)
        {
            Debug.Log("Card " + card.num + " of " + card.suit);
        }*/

        return cards;
    }

    public void ShuffleDeck<T>(List<T> list)
    {
        // shuffle cards in deck, then return shuffled deck
        System.Random rand = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = rand.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }

    }

    public void Deal(Card[] deck)
    {
        // deal out the cards on the board
    }
}

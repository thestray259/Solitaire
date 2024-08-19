using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Card[] deck = new Card[52];

    private void Start()
    {
        // add cards to deck
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

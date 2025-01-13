using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // new game
    // keeps track of score and time to complete and num of moves
    // undo
    // hint
    // deal 1 card or 3

    public Sprite[] cardFaces;
    public List<Card> cards;

    public Deck deck;

    void Start()
    {
        cards = deck.GenerateDeck();
        deck.ShuffleDeck(cards);

/*        foreach (var card in cards)
        {
            Debug.Log("Card " + card.num + " of " + card.suit);
        }*/
    }

    void Update()
    {
        
    }
}

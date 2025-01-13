using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // new game
    // keeps track of score and time to complete and num of moves
    // undo and moves taken
    // hint
    // deal 1 card or 3

    [SerializeField] GameObject cardPrefab;

    public Sprite[] cardFaces;
    public List<string> cards;

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

    public void Deal(List<string> deck)
    {
        // deal out the cards on the board
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach (string card in deck)
        {
            GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z - zOffset), Quaternion.identity);
        }
    }
}

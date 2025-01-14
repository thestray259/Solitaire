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

    public string[] suits = { "S", "H", "C", "D" };
    public string[] nums = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    void Start()
    {
        cards = GenerateDeck();
        ShuffleDeck(cards);
        Deal(cards);

/*        foreach (var card in cards)
        {
            Debug.Log("Card " + card.num + " of " + card.suit);
        }*/
    }

    void Update()
    {
        
    }

    public List<string> GenerateDeck()
    {
        List<string> newDeck = new();
        foreach (string s in suits)
        {
            foreach (string n in nums)
            {
                newDeck.Add(n + s);
            }
        }

        return newDeck;
    }

    public void ShuffleDeck<T>(List<T> list)
    {
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

    public void Deal(List<string> deck)
    {
        // deal out the cards on the board
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach (string card in deck)
        {
            GameObject newCard = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z - zOffset), Quaternion.identity);
            newCard.name = card;
            newCard.GetComponent<Selectable>().faceUp = true;

            yOffset += 9f;
            zOffset += 0.03f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    // new game
    // keeps track of score and time to complete and num of moves
    // undo and moves taken
    // hint
    // deal 1 card or 3

    [SerializeField] GameObject cardPrefab;
    public GameObject[] bottomPos;
    public GameObject[] topPos;

    public Sprite[] cardFaces;
    public List<string> cards;

    public string[] suits = { "S", "H", "C", "D" };
    public string[] nums = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public List<string>[] bottoms;
    public List<string>[] tops;

    // card piles
    private List<string> bottom1 = new List<string>();
    private List<string> bottom2 = new List<string>();
    private List<string> bottom3 = new List<string>();
    private List<string> bottom4 = new List<string>();
    private List<string> bottom5 = new List<string>();
    private List<string> bottom6 = new List<string>();
    private List<string> bottom7 = new List<string>();

    void Start()
    {
        bottoms = new List<string>[] { bottom1, bottom2, bottom3, bottom4, bottom5, bottom6, bottom7 };

        PlayCards();


    }

    void Update()
    {
        
    }

    public void PlayCards()
    {
        cards = GenerateDeck();
        ShuffleDeck(cards);

        Sort();
        StartCoroutine(Deal());

        /*        foreach (var card in cards)
        {
            Debug.Log("Card " + card.num + " of " + card.suit);
        }*/
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

    IEnumerator Deal()
    {
        for (int i = 0; i < 7; i++)
        {
            float yOffset = 0;
            float zOffset = 0.03f;
            foreach (string card in bottoms[i])
            {
                yield return new WaitForSeconds(0.1f);
                GameObject newCard = Instantiate(cardPrefab, new Vector3(bottomPos[i].transform.position.x, bottomPos[i].transform.position.y - yOffset, bottomPos[i].transform.position.z - zOffset), Quaternion.identity, bottomPos[i].transform);
                newCard.name = card;
                if (card == bottoms[i][bottoms[i].Count - 1])
                {
                    newCard.GetComponent<Selectable>().faceUp = true;
                }

                yOffset += 0.3f;
                zOffset += 0.03f;
            }
        }
    }

    public void Sort()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = i; j < 7; j++)
            {
                bottoms[j].Add(cards.Last<string>());
                cards.RemoveAt(cards.Count - 1);
            }
        }
    }
}

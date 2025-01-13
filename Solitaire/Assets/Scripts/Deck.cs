using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public string[] suits = { "S", "H", "C", "D" };
    public string[] nums = {"A", "1", "2", "3",  "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    public List<string> GenerateDeck()
    {
        List<string> newDeck = new();
        foreach (string s in suits)
        {
            foreach (string n in nums)
            {
                newDeck.Add(s + n);
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

    }
}

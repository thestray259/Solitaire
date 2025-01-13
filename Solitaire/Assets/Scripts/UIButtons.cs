using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    // OnClick calls

    public void OnNewGame()
    {
        // clear board, shuffle, and deal new cards
    }

    public void OnPause()
    {
        // pause game timer, display pause menu
    }

    public void OnResume()
    {
        // resume game timer, hide pause menu
    }

    public void OnUndo()
    {
        // move last moved card(s) back where it was
    }

    public void OnHint()
    {
        // shake effect on card that can be moved or draw pile
        // if nothing in draw pile can be played, display no moves
    }
}

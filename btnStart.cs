using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class btnStart : MonoBehaviour
{

    //  Starts the game when pressed.
    public void StartGame()
    {

        GameObject.Find("manInit").GetComponent<man_game>().StartNewGame();
        GameObject.Find("manInit").GetComponent<man_game>().round_number = 0;

        this.StartRound();

    }

    //  Start the round.
    public void StartRound()
    {

        int round = GameObject.Find("manInit").GetComponent<man_game>().round_number;
        int total_nums = GameObject.Find("manInit").GetComponent<man_game>().fibbo[round];

        for (int i = 0; i < total_nums; i++)
        {
            GameObject.Find("manInit").GetComponent<man_game>().RandomSequence();
        }

        //  Play the sequence.
        StartCoroutine(GameObject.Find("manInit").GetComponent<man_simon>().PlaySequence());

    }
    
}

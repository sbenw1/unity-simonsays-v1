using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


//  The purpose of this class is to  make sure that the 
//  round counter label is always updated.

public class round_counter : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

        int currentRound = GameObject.Find("manInit").GetComponent<man_game>().round_number + 1;
        int totalRound = GameObject.Find("manInit").GetComponent<man_game>().total_rounds;

        GameObject.Find("lblOutof").GetComponent<Text>().text = "Round " + currentRound + " out of " + totalRound;

    }
}

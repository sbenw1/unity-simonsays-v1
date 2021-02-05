using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class man_button : MonoBehaviour
{

    //  The on click event.
    public void OnMouseDown()
    {

        if(GameObject.Find("manInit").GetComponent<man_simon>().SequenceIsPlaying == false)
        {
            switch (this.name)
            {
                case "red":

                    this.EnterRed();

                    break;

                case "blue":

                    this.EnterBlue();

                    break;

                case "green":

                    this.EnterGreen();

                    break;

                case "yellow":

                    this.EnterYellow();

                    break;

            }

        }

    }

    public void EnterRed()
    {
        int colorCode = 1;

        GameObject.Find("red_note_fx").GetComponent<AudioSource>().Play();

        //  Assign code to the current code.
        GameObject.Find("manInit").GetComponent<man_game>().entered_code = colorCode;

        //  Check the code to see if it is correct.
        this.CheckCode();

    }

    public void EnterBlue()
    {
        int colorCode = 2;

        GameObject.Find("blue_note_fx").GetComponent<AudioSource>().Play();

        //  Assign code to the current code.
        GameObject.Find("manInit").GetComponent<man_game>().entered_code = colorCode;

        //  Check the code to see if it is correct.
        this.CheckCode();

    }

    public void EnterGreen()
    {
        int colorCode = 3;

        GameObject.Find("green_note_fx").GetComponent<AudioSource>().Play();

        //  Assign code to the current code.
        GameObject.Find("manInit").GetComponent<man_game>().entered_code = colorCode;

        //  Check the code to see if it is correct.
        this.CheckCode();

    }

    public void EnterYellow()
    {

        int colorCode = 4;

        GameObject.Find("yellow_note_fx").GetComponent<AudioSource>().Play();

        //  Assign code to the current code.
        GameObject.Find("manInit").GetComponent<man_game>().entered_code = colorCode;

        //  Check the code to see if it is correct.
        this.CheckCode();

    }

    public void CheckCode()
    {

        int currentCode = GameObject.Find("manInit").GetComponent<man_game>().entered_code;
        int currentPos = GameObject.Find("manInit").GetComponent<man_game>().counter;

        if (currentCode == GameObject.Find("manInit").GetComponent<man_game>().current_sequence[currentPos])
        {

            //  While checking the code, check to see if the counter is last. If it is, then 
            //  go to next round. Otherwise, increase the counter.
            if (GameObject.Find("manInit").GetComponent<man_game>().counter == GameObject.Find("manInit").GetComponent<man_game>().current_sequence.Count-1)
            {

                //  Go to next round
                GameObject.Find("manInit").GetComponent<man_game>().round_number++;
                GameObject.Find("lblOutof").GetComponent<Text>().text = "Round " + GameObject.Find("manInit").GetComponent<man_game>().round_number + " of 5";
               

                GameObject.Find("manInit").GetComponent<man_game>().StartNewGame();

                //  Play the next sequence.
                GameObject.Find("manInit").GetComponent<btnStart>().StartRound();
                

            } else
            {
                GameObject.Find("manInit").GetComponent<man_game>().counter++;
            }


        }
        else
        {
            GameObject.Find("game_over").GetComponent<AudioSource>().Play();
            GameObject.Find("lblTutorial").GetComponent<Text>().text = "You lose!";
        }

    }

  
}

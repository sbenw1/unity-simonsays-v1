using System.Collections;
using System.Collections.Generic;

//  Unity stuff
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class man_simon : MonoBehaviour
{

    //  Number of seconds to wait for.
    public int SecondsWaitFor;

    //  Is the sequence currently playing?
    public bool SequenceIsPlaying;


    void Start()
    {
        this.SecondsWaitFor = 2;
    }

    //  Trying this as a neumerator
    public IEnumerator PlaySequence()
    {

        if(GameObject.Find("manInit").GetComponent<man_game>().round_number == GameObject.Find("manInit").GetComponent<man_game>().total_rounds)
        {

            GameObject.Find("lblTutorial").GetComponent<Text>().text = "Good job, you win for now!";

        } else
        {

            man_game mg = GameObject.Find("manInit").GetComponent<man_game>();

            for (int i = 0; i < mg.current_sequence.Count; i++)
            {

                switch (mg.current_sequence[i])
                {
                    case 1:
                        StartCoroutine(SwapRed());
                        break;

                    case 2:
                        StartCoroutine(SwapBlue());
                        break;

                    case 3:
                        StartCoroutine(SwapGreen());
                        break;

                    case 4:
                        StartCoroutine(SwapYellow());
                        break;
                }

                this.SequenceIsPlaying = true;

                GameObject.Find("lblTutorial").GetComponent<Text>().text = "Wait...";

                yield return new WaitForSeconds(this.SecondsWaitFor);

                this.SequenceIsPlaying = false;

                GameObject.Find("lblTutorial").GetComponent<Text>().text = "Go!";

            }

        }

        

    }


    //  #####################################################


    IEnumerator SwapRed()
    {
        GameObject.Find("lblTutorial").GetComponent<Text>().text = "Wait...";

        //  The coords of the sprite.
        int rsPosX = -3;
        int rsPosY = 0;

        int rdPosX = -3;
        int rdPosY = -10;
        int rdPosZ = -1;

        GameObject.Find("red-wdot").transform.position = new Vector3(rsPosX, rsPosY, rdPosZ);

        GameObject.Find("red_note_fx").GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(2);

        GameObject.Find("red-wdot").transform.position = new Vector3(rdPosX, rdPosY, rdPosZ);
  
    }

    IEnumerator SwapBlue()
    {

        GameObject.Find("lblTutorial").GetComponent<Text>().text = "Wait...";

        //  The coords of the sprite.
        int rsPosX = -1;
        int rsPosY = 0;

        int rdPosX = -1;
        int rdPosY = -10;
        int rdPosZ = -1;

        GameObject.Find("blue-wdot").transform.position = new Vector3(rsPosX, rsPosY, rdPosZ);

        GameObject.Find("blue_note_fx").GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(this.SecondsWaitFor);

        GameObject.Find("blue-wdot").transform.position = new Vector3(rdPosX, rdPosY, rdPosZ);

    }

    
    IEnumerator SwapGreen()
    {

        GameObject.Find("lblTutorial").GetComponent<Text>().text = "Wait...";

        //  The coords of the sprite.
        int rsPosX = 1;
        int rsPosY = 0;

        int rdPosX = 1;
        int rdPosY = -10;
        int rdPosZ = -1;

        GameObject.Find("green-wdot").transform.position = new Vector3(rsPosX, rsPosY, rdPosZ);
 
        GameObject.Find("green_note_fx").GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(this.SecondsWaitFor);

        GameObject.Find("green-wdot").transform.position = new Vector3(rdPosX, rdPosY, rdPosZ);
      
    }

    IEnumerator SwapYellow()
    {

        GameObject.Find("lblTutorial").GetComponent<Text>().text = "Wait...";

        //  The coords of the sprite.
        int rsPosX = 3;
        int rsPosY = 0;

        int rdPosX = 3;
        int rdPosY = -10;
        int rdPosZ = -1;

        GameObject.Find("yellow-wdot").transform.position = new Vector3(rsPosX, rsPosY, rdPosZ);
   
        GameObject.Find("yellow_note_fx").GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(this.SecondsWaitFor);

        GameObject.Find("yellow-wdot").transform.position = new Vector3(rdPosX, rdPosY, rdPosZ);
      

    }



}

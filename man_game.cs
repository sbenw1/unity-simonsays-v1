using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class man_game : MonoBehaviour
{

    //  The current sequence, and the entered sequence.
    //  Current sequence is the one that is matched against what 
    //  the player inputs, which is entered sequence.
    public List<int> current_sequence;
    public int entered_code;
    public int counter;

    //  The fibonnaci sequence.
    public List<int> fibbo;

    //  Tells the game if to play the sequence.
    public bool sequence_is_playing;

    //  The number of rounds game is on.
    public int round_number;

    //  Random number generator
    public System.Random r;

    //  The total number of rounds to play at.
    public int total_rounds;

    // Start is called before the first frame update
    void Start()
    {

        //  Create random object.
        this.r = new System.Random();

        this.current_sequence = new List<int>();

        this.entered_code = 0;
        this.counter = 0;
        this.round_number = 0;
        this.total_rounds = 5;

        this.sequence_is_playing = false;

        //  THE FIBBONACI SEQUENCE
        //  This is for the number of items added into the current sequence.

        this.fibbo = new List<int>();

        int fib1 = 2;
        int fib2 = 3;

        this.fibbo.Add(fib1);
        this.fibbo.Add(fib2);

        for(int i = 0; i < 6; i++)
        {

            int fib3 = fib1 + fib2;

            this.fibbo.Add(fib3);

            fib1 = fib2;
            fib2 = fib3;

        }

        // ##########################################################


    }

    //  Creates random numbers, between 1-4, and adds them to the 
    //  current sequence depending on how many rounds have passed.
    //  1 = red, 2 = blue, 3 = green, 4 = yellow
    public void RandomSequence()
    {

        //  Get a random number between 1 and four.
        int color = this.r.Next(1, 4);

        //  Add the colour to the sequence.
        this.current_sequence.Add(color);

    }

    //  Resets the current and entered sequences.
    public void StartNewGame()
    {
        this.current_sequence = new List<int>();

        this.entered_code = 0;
        this.counter = 0;
    }


}

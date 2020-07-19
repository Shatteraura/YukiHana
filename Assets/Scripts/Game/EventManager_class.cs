using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum currentArrayEnum { HBUF, YBUF, BBUF, BHF1, BHF2, BHF3, BYF1, BYF2, BYF3}

public class EventManager_class : MonoBehaviour
{
    public GameManager_class mRef;

    public int indexNum = 0;
    public int dialogueNum = 0;
    public int jumpIndex = 0;
    public int jumpArray = 0;
    public int randStart = 0;
    public int randEnd = 0;

    public currentArrayEnum currentArray;

    public string currentString;

    public Text dialogueText;

    //[indexNum, DialogueNum]  indexNum is Listed at the END of the Lines
    //#S: START, --- #E: End, --- #N: Next, --- #J *: Jump Index (INum) --- #JA * *: Jump Array (ANum) (INum) --- #F (FNum): Expressions
    //If a variable is referenced it is listed in the comment above the first entry
    //Just next to the description comment is the Enum number of the event array
    //Master Array - Allows the arrays to be read arbitrarily by currentString

    //2D Arrays for Event Descriptions

    //Just Hana Buffet[0]
    private string[,] buffetH = new string[,]
    {
        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "I decided to take Hana out to the Buffet.", "#F", "As I arrived, I was shocked to see her already standing there. Checking my watch I realised she was even earlier than me!", "#F", "Hey! Hana!", "#J 11" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]

        //SPECULATIVE - Introductions - Variable indexNum - Fame

        //Hana Buffet Intro Lines - Variable indexNum - jumpIndex
        { "#S", "#F", "We made some smalltalk as we walked through the door.", "#F", "Hana looked pleased.", "#F", "Other stuff", "#JA 3 0" }, //[11]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[12]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[13]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[14]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[15]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[16]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[17]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[18]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[19]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[20]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[21]

    };

    //Just Yuki Buffet[1]
    private string[,] buffetY = new string[,]
    {
        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]

        //SPECULATIVE - Introductions - Variable indexNum - Fame
    };

    //Both Buffet[2]
    private string[,] buffetB = new string[,]
    {
        //Starting Lines - Variable indexNum - Weight Comparison

        //Hana Heavier
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]

        //Yuki Heavier
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]

        //SPECULATIVE - Introductions - Variable indexNum - Fame
    };


    //-----------------------------------------------------------------------------------------------------------------
    //Double Arrays for Eating at the buffet --- One Array Per Level Of Feedee! 

    //[3]
    private string[,] buffetHF1 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "Hana ate a lot", "#F", "it was hot", "#F", "fatness", "#E" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };

    //[4]
    private string[,] buffetHF2 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };

    //[5]
    private string[,] buffetHF3 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };

    //[6]
    private string[,] buffetYF1 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };

    //[7]
    private string[,] buffetYF2 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };

    //[8]
    private string[,] buffetYF3 = new string[,] {

        //Starting Lines - Variable indexNum - Weight
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[0]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[1]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[2]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[3]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[4]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[5]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[6]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[7]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[8]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[9]
        { "#S", "#F", "ZERO", "#F", "boop", "#F", "Bop", "#J" }, //[10]
    };



    private string[][,] masterArray;

    // Start is called before the first frame update
    private void Start()
    {
        masterArray = new string[][,]
        {
            buffetH,buffetY,buffetB,buffetHF1,buffetHF2,buffetHF3,buffetYF1,buffetYF2,buffetYF3 
        };
    }

    // Update is called once per frame
    private void Update()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            clickThrough();
            arrayLogic();
            currentString = masterArray[(int)currentArray][indexNum, dialogueNum];
        }
    }


    //Allows the player to advance the dialogue - clicklock prevets weirdness with the hash strings
    private void clickThrough()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dialogueNum++;
        } 
    }

    //Advanced logic that governs the Hash symbols in the strings
    private void arrayLogic()
    {
        string[] words = currentString.Split(' ');

        //Jump Index
        if (words[0] == "#J")
        {
            dialogueText.text = "";
            jumpIndex = int.Parse(words[1]);
            dialogueNum = 1;
            indexNum = jumpIndex;
        }

        //Jump Array
        if (words[0] == "#JA")
        {
            dialogueText.text = "";
            jumpArray = int.Parse(words[1]);
            jumpIndex = int.Parse(words[2]);
            dialogueNum = 1;
            indexNum = jumpIndex;
            currentArray = (currentArrayEnum)jumpArray;
        }

        //Expressions
        if (words[0] == "#F")
        {
            dialogueNum++;
            dialogueText.text = "";
        }

        switch (currentString)
        {
            //Start
            case "#S":
                dialogueText.text = "";
                dialogueNum += 1;
                mRef.resetButtons = false;
                break;

            //End
            case "#E":
                mRef.eventType = eventTypeEnum.none;
                dialogueText.text = "";
                indexNum = 0;
                dialogueNum = 0;
                mRef.resetButtons = true;
                break;

            //Next
            case "#N":
                dialogueText.text = "";
                indexNum += 1;
                dialogueNum = 1;
                break;

            default:
                dialogueText.text = currentString;
                break;
        }

    }

}

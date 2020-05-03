using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager_class : MonoBehaviour
{
    public GameManager_class mRef;

    public int sceneNum = 0;
    public int dialogueNum = 0;

    public bool eventSet;

    public Text dialogueText;


    //{ "S", "", "", "", "" }, // Scene Description ONLY ON SCENE START (Dialogue Part e.g. Intro).  UNIQUE Catalogue Number on each!

    //[0,0] - Type Zero, Option Zero --- For example [Scene Stage , Specific Dialog] --- The scene stage will be commented next to the list of dialogue options
    //NOTES: Just grab scene numbers based on stats! --- Manage the characters selected by code, make their lines play out one after the other! --- Happiness and stress could overule eachother!
    private string[,] buffetLibrary = new string[,] { 
        { "S", "We decided return to the buffet place we went to when we all met, the girls seemed pretty excited.", "Yuki: \"This time let's try not to overdo it *Haha*\"", "Hana: \"I'm sure its fine, as the manager said it's okay to indulge once in a while *Giggle*\"", "" }, //BuffetBoth(Intro) < 25 fame 0
        { "S", "", "", "", "" }, // BuffetBoth(Intro) > 25 fame
        { "S", "", "", "", "" }, // BuffetBoth(Intro) > 50 fame
        { "S", "", "", "", "" }, // BuffetBoth(Intro) > 75 fame

        { "S", "", "", "", "" }, // BuffetBoth(Early) < 200 weight Hana
        { "S", "", "", "", "" }, // BuffetBoth(Early) > 200 weight Hana
        { "S", "", "", "", "" }, // BuffetBoth(Early) > 300 weight Hana

        { "S", "", "", "", "" }, // BuffetBoth(Early) < 200 weight Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Early) > 200 weight Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Early) > 300 weight Yuki

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 happiness Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 happiness Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 happiness Hana

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 happiness Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 happiness Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 happiness Yuki

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 stress Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 stress Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 stress Hana

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 stress Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 stress Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 stress Yuki

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 feedee Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 feedee Hana
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 feedee Hana

        { "S", "", "", "", "" }, // BuffetBoth(Mid) < 25 feedee Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 25 feedee Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Mid) > 50 feedee Yuki

        { "S", "", "", "", "" }, // BuffetBoth(Late) > 50 Love Hana
        { "S", "", "", "", "" }, // BuffetBoth(Late) > 75 Love Hana

        { "S", "", "", "", "" }, // BuffetBoth(Late) > 50 Love Yuki
        { "S", "", "", "", "" }, // BuffetBoth(Late) > 75 Love Yuki


        { "S", "I decided to spend some time relaxing with Yuki, I invited her to the buffet place.", "Yuki: \"Heeeey! Hows it going Mr. Manager?\"", "\"All good Yuki, ready for dinner?\"", "" }, //BuffetYuki
        { "S", "", "", "", "" }, //BuffetYuki

        { "S", "Potato", "Jeff", "Tomato", "" } //BuffetHana

    };

    private string[,] restaurantLibrary = new string[,] {
        { "S", "You walk inside", "You amble inside", "You walk through the door", "" }, //RestaurantIntroBoth 0
        { "S", "Potato", "Jeff", "Tomato", "" }, //RestaurantIntroHana 1
        { "S", "Potato", "Jeff", "Tomato", "" } //RestaurantIntroYuki 2
    };

    private string[,] talkLibrary = new string[,] {
        { "S", "You walk inside", "You amble inside", "You walk through the door", "" }, //TalkIntroHana 0
        { "S", "Potato", "Jeff", "Tomato", "" } //TalkIntroYuki 1
    };

    private string[,] concertLibrary = new string[,] {
        { "S", "You walk inside", "You amble inside", "You walk through the door", "" }, //ConcertIntro 0
        { "S", "Potato", "Jeff", "Tomato", "" } //ConcertBeginning 1
    };

    private string[,] tvadLibrary = new string[,] {
        { "S", "You walk inside", "You amble inside", "You walk through the door", "" }, //TVADIntro 0
        { "S", "Potato", "Jeff", "Tomato", "" } //TVADBeginning 1
    };




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            eventManager();
            clickThrough();

            if (buffetLibrary[sceneNum, dialogueNum] != "End")
            {
                dialogueText.text = buffetLibrary[sceneNum, dialogueNum];
            }
        }
        else
        {
            resetAll();
        }
    }

    void resetAll()
    {
            dialogueText.text = "";   
    }

    //Allows the player to advance the dialogue - scene num moves onto the next library entry
    void clickThrough()
    {
        if (Input.GetMouseButtonDown(0) && buffetLibrary[sceneNum, dialogueNum] != "")
        {
            dialogueNum++;
        }

        else if (buffetLibrary[sceneNum, dialogueNum] == "")
        {
            dialogueNum = 1;
            sceneNum++;
        }

        else if (buffetLibrary[sceneNum, dialogueNum] == "End")
        {
            dialogueText.text = "";
            mRef.eventType = eventTypeEnum.none;
            mRef.resetButtons = true;
        }
    }

    //Type of event - Check who is there - Augment Scene with stats - Start the Scene - adjust stats after scene!
    void eventManager()
    {           

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager_class : MonoBehaviour
{
    public GameManager_class mRef;

    public int sceneNum;
    public int dialogueNum;
    public int sceneChangeNum;

    public Text dialogueText;



    //[0,0] - Type Zero, Option Zero --- For example [Scene Stage , Specific Dialog] --- The scene stage will be commented next to the list of dialogue options
    private string[,] buffetLibrary = new string[,] { 
        { "You walk inside", "You amble inside", "You walk through the door" }, //BuffetIntroBoth 0
        { "Potato", "Jeff", "Tomato" }, //BuffetIntroHana 1
        { "Potato", "Jeff", "Tomato" } //BuffetIntroYuki 2
    };

    private string[,] restaurantLibrary = new string[,] {
        { "You walk inside", "You amble inside", "You walk through the door" }, //RestaurantIntroBoth 0
        { "Potato", "Jeff", "Tomato" }, //RestaurantIntroHana 1
        { "Potato", "Jeff", "Tomato" } //RestaurantIntroYuki 2
    };

    private string[,] talkLibrary = new string[,] {
        { "You walk inside", "You amble inside", "You walk through the door" }, //TalkIntroHana 0
        { "Potato", "Jeff", "Tomato" } //TalkIntroYuki 1
    };

    private string[,] concertLibrary = new string[,] {
        { "You walk inside", "You amble inside", "You walk through the door" }, //ConcertIntro 0
        { "Potato", "Jeff", "Tomato" } //ConcertBeginning 1
    };

    private string[,] tvadLibrary = new string[,] {
        { "You walk inside", "You amble inside", "You walk through the door" }, //TVADIntro 0
        { "Potato", "Jeff", "Tomato" } //TVADBeginning 1
    };




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resetAll();
        eventManager();
        clickThrough();
    }

    void resetAll()
    {
        if (mRef.eventType == eventTypeEnum.none)
        {
            dialogueText.text = "";
        }
    }

    //Allows the player to advance the dialogue - dialogueCurrent Starts at int 1!
    void clickThrough()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            if (Input.GetMouseButtonDown(0))
            {
                
            }
        }
    }

    //Type of event - Check who is there - Start Scene - Augment Scene with stats - adjust stats after scene!
    void eventManager()
    {
        switch (mRef.eventType)
        {
            case eventTypeEnum.buffet:
                buffetEvent();
                break;

            case eventTypeEnum.restaurant:
                restaurantEvent();
                break;

            case eventTypeEnum.talk:
                talkEvent();
                break;

            case eventTypeEnum.concert:
                concertEvent();
                break;

            case eventTypeEnum.tvad:
                tvAdEvent();
                break;
        }
    }


    //Handlers for the individual events with either or both characters, fill the cases with code to begin the text system; work on locking events behind cost later!
    void buffetEvent()
    {
        switch (mRef.characterSelect)
        {
            case characterSelectEnum.both:
                //dialogueText.text = buffetLibrary[0, 0];
                break;

            case characterSelectEnum.hana:
                break;

            case characterSelectEnum.yuki:
                break;
        }
    }

    void restaurantEvent()
    {
        switch (mRef.characterSelect)
        {
            case characterSelectEnum.both:
                break;

            case characterSelectEnum.hana:
                break;

            case characterSelectEnum.yuki:
                break;
        }
    }

    void talkEvent()
    {
        switch (mRef.characterSelect)
        {
            case characterSelectEnum.both:
                break;

            case characterSelectEnum.hana:
                break;

            case characterSelectEnum.yuki:
                break;
        }
    }

    void concertEvent()
    {
        switch (mRef.characterSelect)
        {
            case characterSelectEnum.both:
                break;

            case characterSelectEnum.hana:
                break;

            case characterSelectEnum.yuki:
                break;
        }
    }

    void tvAdEvent()
    {
        switch (mRef.characterSelect)
        {
            case characterSelectEnum.both:
                break;

            case characterSelectEnum.hana:
                break;

            case characterSelectEnum.yuki:
                break;
        }
    }

}

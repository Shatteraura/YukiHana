using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum buttonTypeEnum { buffet, restaurant, talk, concert, tvad }

public class LocationButtons_class : MonoBehaviour
{
    public buttonTypeEnum buttonType;

    public GameManager_class mRef;

    public int buttonSwitch;

    public Sprite normal;
    public Sprite highlight;

    // Start is called before the first frame update
    void Start()
    {
        switch (buttonType)
        {
            case buttonTypeEnum.buffet:
                mRef.buffet = this.transform.position;
                break;

            case buttonTypeEnum.restaurant:
                mRef.restaurant = this.transform.position;
                break;

            case buttonTypeEnum.concert:
                mRef.concert = this.transform.position;
                break;

            case buttonTypeEnum.tvad:
                mRef.tvad = this.transform.position;
                break;

            case buttonTypeEnum.talk:
                mRef.talk = this.transform.position;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        hideButtons();
    }

    void hideButtons()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            this.transform.position = new Vector3(100, 100, 0);
        }

        if (mRef.resetButtons == true)
        {
            switch (buttonType)
            {
                case buttonTypeEnum.buffet:
                    this.transform.position = mRef.buffet;
                    break;

                case buttonTypeEnum.restaurant:
                    this.transform.position = mRef.restaurant;
                    break;

                case buttonTypeEnum.concert:
                    this.transform.position = mRef.concert;
                    break;

                case buttonTypeEnum.tvad:
                    this.transform.position = mRef.tvad;
                    break;

                case buttonTypeEnum.talk:
                    this.transform.position = mRef.talk;
                    break;

            }
        }
    }

    private void OnMouseEnter()
    {
        this.GetComponent<SpriteRenderer>().sprite = highlight;
    }

    private void OnMouseExit()
    {
        this.GetComponent<SpriteRenderer>().sprite = normal;
    }


    //Governs how many characters you need/want at an event, buttonswitch prevents conflicts between the buttons fighting over numbers
    private void OnMouseDown()
    {
        if (mRef.characterSelect == characterSelectEnum.both && mRef.eventLock == false && buttonSwitch == 1)
        {
            switch (buttonType)
            {
                case buttonTypeEnum.concert:
                    mRef.eventType = eventTypeEnum.concert;
                    mRef.resetButtons = false;
                    break;

                case buttonTypeEnum.tvad:
                    mRef.eventType = eventTypeEnum.tvad;
                    mRef.resetButtons = false;
                    break;
            }

            mRef.eventLock = true;
        }

        //Talk isnt locked even after an event
        if (mRef.characterSelect == characterSelectEnum.hana || mRef.characterSelect == characterSelectEnum.yuki && buttonSwitch == 2)
        {
            switch (buttonType)
            {
                case buttonTypeEnum.talk:
                    mRef.eventType = eventTypeEnum.talk;
                    mRef.resetButtons = false;
                    break;
            }

            mRef.eventLock = true;
        }

        if (mRef.characterSelect != characterSelectEnum.none && mRef.eventLock == false && buttonSwitch == 3)
        {
            switch (buttonType)
            {
                case buttonTypeEnum.buffet:
                    mRef.eventType = eventTypeEnum.buffet;
                    mRef.resetButtons = false;
                    break;

                case buttonTypeEnum.restaurant:
                    mRef.eventType = eventTypeEnum.restaurant;
                    mRef.resetButtons = false;
                    break;
            }

            mRef.eventLock = true;
        }      
    }
}

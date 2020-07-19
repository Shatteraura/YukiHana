using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum eventTypeEnum { buffet, restaurant, talk, concert, tvad, none }
public enum characterSelectEnum { hana, yuki, both, none }

public class GameManager_class : MonoBehaviour
{
    public eventTypeEnum eventType;
    public characterSelectEnum characterSelect;

    public Text mText;

    public int totalMoney;
    public int totalFame;

    public int eventCost;

    public int hanaHappiness = 50;
    public int hanaStress;
    public int hanaWeight = 100;
    public int hanaFeedee = 1;
    public int hanaLove = 0;
    public bool hanaStuffed = false;

    public int yukiHappiness = 50;
    public int yukiStress;
    public int yukiWeight = 100;
    public int yukiFeedee = 1;
    public int yukiLove = 0;
    public bool yukiStuffed = false;

    public bool hanaSelect;
    public bool yukiSelect;

    public bool eventLock = false;
    public bool resetButtons = true;

    //Global button positions so they can reset
    public Vector3 buffet;
    public Vector3 restaurant;
    public Vector3 concert;
    public Vector3 talk;
    public Vector3 tvad;
    public Vector3 endturn;
    public Vector3 yuki;
    public Vector3 hana;

    // Start is called before the first frame update
    void Start()
    {
        eventType = eventTypeEnum.none;
        mText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        whoIsSelected();
    }

    void whoIsSelected()
    {
        if (hanaSelect == true && yukiSelect == true)
        {
            characterSelect = characterSelectEnum.both;
        }

        if (hanaSelect == true && yukiSelect == false)
        {
            characterSelect = characterSelectEnum.hana;
        }

        if (hanaSelect == false && yukiSelect == true)
        {
            characterSelect = characterSelectEnum.yuki;
        }

        if (hanaSelect == false && yukiSelect == false)
        {
            characterSelect = characterSelectEnum.none;
        }
    }


    public int feedeeLevelH()
    {
        if (hanaFeedee < 10)
        {
            return 1;
        }
        else if (hanaFeedee < 20)
        {
            return 2;
        }
        else if (hanaFeedee < 30)
        {
            return 3;
        }

        return 0;
    }

    public int feedeeLevelY()
    {
        if (yukiFeedee < 10)
        {
            return 1;
        }
        else if (yukiFeedee < 20)
        {
            return 2;
        }
        else if (yukiFeedee < 30)
        {
            return 3;
        }

        return 0;
    }



    public int weightLevelH()
    {
        if (hanaWeight < 150)
        {
            return 0;
        }
        else if (hanaWeight < 200)
        {
            return 1;
        }
        else if (hanaWeight < 250)
        {
            return 2;
        }
        else if (hanaWeight < 300)
        {
            return 3;
        }
        else if (hanaWeight < 350)
        {
            return 4;
        }
        else if (hanaWeight < 400)
        {
            return 5;
        }
        else if (hanaWeight < 450)
        {
            return 6;
        }
        else if (hanaWeight < 500)
        {
            return 7;
        }
        else if (hanaWeight < 550)
        {
            return 8;
        }
        else if (hanaWeight < 600)
        {
            return 9;
        }
        else if (hanaWeight <= 650)
        {
            return 10;
        }

        return 0;
    }

    public int weightLevelY()
    {
        if (yukiWeight < 150)
        {
            return 0;
        }
        else if (yukiWeight < 200)
        {
            return 1;
        }
        else if (yukiWeight < 250)
        {
            return 2;
        }
        else if (yukiWeight < 300)
        {
            return 3;
        }
        else if (yukiWeight < 350)
        {
            return 4;
        }
        else if (yukiWeight < 400)
        {
            return 5;
        }
        else if (yukiWeight < 450)
        {
            return 6;
        }
        else if (yukiWeight < 500)
        {
            return 7;
        }
        else if (yukiWeight < 550)
        {
            return 8;
        }
        else if (yukiWeight < 600)
        {
            return 9;
        }
        else if (yukiWeight <= 650)
        {
            return 10;
        }

        return 0;
    }
}

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
    public int hanaWeight = 120;
    public int hanaFeedee = 0;
    public int hanaLove = 0;

    public int yukiHappiness = 50;
    public int yukiStress;
    public int yukiWeight = 120;
    public int yukiFeedee = 0;
    public int yukiLove = 0;

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
}

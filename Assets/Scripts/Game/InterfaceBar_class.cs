using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceBar_class : MonoBehaviour
{
    public GameManager_class mRef;

    public Sprite mainScreen;
    public Sprite inEvent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        changeSprite();
    }

    //Changes the interface bar, it can be used as the dialogue box, or to describe the buttons on the main screen
    void changeSprite()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            this.GetComponent<SpriteRenderer>().sprite = inEvent;
        }

        if (mRef.eventType == eventTypeEnum.none)
        {
            this.GetComponent<SpriteRenderer>().sprite = mainScreen;
        }
    }
}

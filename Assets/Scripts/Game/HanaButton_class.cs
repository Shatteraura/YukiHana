using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanaButton_class : MonoBehaviour
{
    public GameManager_class mRef;

    public Sprite normal;
    public Sprite highlight;

    // Start is called before the first frame update
    void Start()
    {
        mRef.hana = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        hideButton();
    }

    void hideButton()
    {
        if (mRef.eventType != eventTypeEnum.none)
        {
            this.transform.position = new Vector3(100, 100, 0);
        }

        if (mRef.resetButtons == true)
        {
            this.transform.position = mRef.hana;
        }
    }

    private void OnMouseEnter()
    {
        this.GetComponent<SpriteRenderer>().sprite = highlight;
    }

    private void OnMouseExit()
    {
        if (mRef.hanaSelect == false)
        {
            this.GetComponent<SpriteRenderer>().sprite = normal;
        }
    }

    private void OnMouseDown()
    {
        if (mRef.hanaSelect == false)
        {
            mRef.hanaSelect = true;
        }

        else
        {
            mRef.hanaSelect = false;
        }

    }
}

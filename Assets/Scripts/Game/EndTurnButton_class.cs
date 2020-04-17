using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton_class : MonoBehaviour
{
    public GameManager_class mRef;

    public Sprite normal;
    public Sprite highlight;

    // Start is called before the first frame update
    void Start()
    {
        mRef.endturn = this.transform.position;
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
            this.transform.position = mRef.endturn;
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

    private void OnMouseDown()
    {
        mRef.eventLock = false;
    }

}

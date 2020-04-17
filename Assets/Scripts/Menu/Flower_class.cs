using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_class : MonoBehaviour
{
    public int flowerNum;
    public Main_class mRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveFlowers();
    }

    void moveFlowers()
    {
        switch (mRef.currentButton)
        {
            case 1:
                if (flowerNum == 1)
                {
                    this.transform.position = new Vector3(4, 0, 0);
                }
                if (flowerNum == 2)
                {
                    this.transform.position = new Vector3(-4, 0, 0);
                }
                break;

            case 2:
                if (flowerNum == 1)
                {
                    this.transform.position = new Vector3(5, -1.5f, 0);
                }
                if (flowerNum == 2)
                {
                    this.transform.position = new Vector3(-5, -1.5f, 0);
                }
                break;

            case 3:
                if (flowerNum == 1)
                {
                    this.transform.position = new Vector3(4, -3, 0);
                }
                if (flowerNum == 2)
                {
                    this.transform.position = new Vector3(-4, -3, 0);
                }
                break;
        }
    }
}

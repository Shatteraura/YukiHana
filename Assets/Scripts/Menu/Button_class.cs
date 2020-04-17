using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_class : MonoBehaviour
{
    public int buttonNum;
    public Main_class mRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        mRef.currentButton = buttonNum;
    }

    private void OnMouseDown()
    {
        switch (buttonNum)
        {
            case 1:
                SceneManager.LoadScene("Intro", LoadSceneMode.Single);
                break;

            case 2:
                break;

            case 3:
                Application.Quit();
                break;
        }
    }
}

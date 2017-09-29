using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIopen : MonoBehaviour
{

    // Use this for initialization
    public GameObject Target;
  
   

    private int Decide = 1;
    
    void Start()
    {
        Target.SetActive(false);
       /* GameObject.Find("Trap").SetActive(false);
        GameObject.Find("Cover").SetActive(false);
        GameObject.Find("Window").SetActive(false);
        GameObject.Find("Door").SetActive(false);
        GameObject.Find("Grunt").SetActive(false);
        GameObject.Find("Elite").SetActive(false);
        */
    }

    // Update is called once per frame
    void Update()
    {



    }

    

    public void clickMenu()
    {
        bool Visible;
        Decide += 1;

        if (Decide % 2 == 0)
        {
            Visible = true;
            Target.SetActive(Visible);
            //GameObject.Find("MenuButton").GetComponent<Button>().enabled = false;
        }

        else
        {
            Visible = false;
            Target.SetActive(Visible);
           //GameObject.Find("MenuButton").GetComponent<Button>().enabled = true;
        }
    }

    

}

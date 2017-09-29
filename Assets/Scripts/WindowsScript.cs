using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsScript : MonoBehaviour {

    public GameObject Window;
    public int WinN;
    public int WinM;

    Vector3 position = new Vector3(450, 260, -5);

    
    // Use this for initialization
    void Start()
    {
        //Window.SetActive(false);
    }


    public void clickDor()
    {
        
       
        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && WinN < WinM)
        {
            Instantiate(Window, position, Quaternion.identity);
          
            WinN++;
        }
    }
}

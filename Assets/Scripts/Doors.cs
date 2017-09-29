using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

    public GameObject Door;
    public int doornm;
    public int doorn;
    

    Vector3 position = new Vector3(450, 260, -5);
    


    // Use this for initialization
    void Start () {
        // Door.SetActive(false);
        
    }
	

    public void clickDor()
    {
       
        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && doorn < doornm )
        {
            Instantiate(Door, position, Quaternion.identity);
           

            doorn++;
        }
    }
}

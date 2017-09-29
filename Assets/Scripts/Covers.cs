using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covers : MonoBehaviour {
    public GameObject Cover;
    
    public int CoN;
    public int CoM;
    Vector3 position = new Vector3(450, 260, -5);

    
    // Use this for initialization
    void Start()
    {
        //Cover.SetActive(false);
    }


    public void clickDor()
    {

        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && CoN < CoM)
        {
             Instantiate(Cover, position, Quaternion.identity);
          
            CoN++;
        }
    }
}
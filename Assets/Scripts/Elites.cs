using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elites : MonoBehaviour {


    public GameObject Elite;
    Vector3 position = new Vector3(450, 260, -5);
    public int ElN;
    public int ElM;
    
    // Use this for initialization
    void Start()
    {
        // Elite.SetActive(false);
    }


    public void clickDor()
    {

        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && ElN < ElM)
        {
            Instantiate(Elite, position, Quaternion.identity);
          
            ElN++;
        }
    }
}

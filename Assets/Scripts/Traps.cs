using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour {

    public GameObject Trap;
    public int TraN;
    public int TraM;
    Vector3 position = new Vector3(450, 260, -5);
    
    // Use this for initialization
    void Start()
    {
       // Trap.SetActive(false);
    }


    public void clickDor()
    {

        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && TraN < TraM)
        {
            Instantiate(Trap, position, Quaternion.identity);
        
            TraN++;
        }
    }
}

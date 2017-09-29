using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM : MonoBehaviour {

    public GameObject CrM;
    public int CMN;
    public int CMM;
    Vector3 position = new Vector3(450, 260, -5);

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void clickDor()
    {

        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && CMN < CMM)
        {
            Instantiate(CrM, position, Quaternion.identity);
            CMN++;
        }
    }
}

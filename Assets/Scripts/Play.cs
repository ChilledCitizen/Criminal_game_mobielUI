using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TouchScript.Gestures;

public class Play : MonoBehaviour {

    
    public int dis;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (dis != 1 && GameObject.Find("CM").GetComponent<CM>().CMN > 0)
        {
            dis = 1;
            GameObject.Find("Traps").GetComponent<Button>().interactable = false;
            GameObject.Find("Covers").GetComponent<Button>().interactable = false;
            GameObject.Find("Windows").GetComponent<Button>().interactable = false;
            GameObject.Find("Doors").GetComponent<Button>().interactable = false;
            GameObject.Find("C(Clone)").GetComponent<ScreenTransformGesture>().enabled = false;
            GameObject.Find("D1(Clone)").GetComponent<ScreenTransformGesture>().enabled = false;
            GameObject.Find("T(Clone)").GetComponent<ScreenTransformGesture>().enabled = false;
            GameObject.Find("W(Clone)").GetComponent<ScreenTransformGesture>().enabled = false;
            GameObject.Find("PlayButton").GetComponent<Button>().interactable = false;
            GameObject.Find("Grunts").GetComponent<Button>().interactable = false;
            GameObject.Find("Elites").GetComponent<Button>().interactable = false;
            GameObject.Find("CM").GetComponent<Button>().interactable = false;
            
        }
    }

}

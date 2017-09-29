using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunts : MonoBehaviour
{

    public GameObject Grunt;
    public int GrN;
    public int GrM;
    Vector3 position = new Vector3(450, 260, -5);
    // Use this for initialization
    void Start()
    {
        // Grunt.SetActive(false);
    }


    public void clickDor()
    {

        int Disable = GameObject.Find("PlayButton").GetComponent<Play>().dis;
        if (Disable != 1 && GrN < GrM)
        {
            Instantiate(Grunt, position, Quaternion.identity);
            
            GrN++;
        }
    }
}

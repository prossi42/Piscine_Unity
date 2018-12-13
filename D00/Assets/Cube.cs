using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public static int isInstanciedA;
    public static int isInstanciedS;
    public static int isInstanciedD;
    private float timeA;
    private float timeS;
    private float timeD;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == CubeSpawner.aInstance.name)
        {
            print("ta mere");
        }
        else if (gameObject.name == CubeSpawner.sInstance.name)
        {
            print("la");
        }
        else
        {
            print("pute");
        }
	}
}

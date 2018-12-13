using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    private Vector3 startPosition = new Vector3();
    private Vector3 downtranslation = new Vector3(0f, 0.01f, 0f);
    public GameObject aPrefab;
    public GameObject sPrefab;
    public GameObject dPrefab;
    public static GameObject aInstance;
    public static GameObject sInstance;
    public static GameObject dInstance;

	// Use this for initialization
	void Start () {
        startPosition = transform.position;
        if (gameObject.name == "spawnA")
            UpdateA();
        else if (gameObject.name == "spawnS")
            UpdateS();
        else
            UpdateD();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "spawnA")
        {
            if (Cube.isInstanciedA == 0)
                UpdateA();
        }
        else if (gameObject.name == "spawnB")
        {
            if (Cube.isInstanciedS == 0)
                UpdateS();
        }
        else
        {
            if (Cube.isInstanciedD == 0)
                UpdateD();
        }
    }

    void UpdateA(){

        aInstance = Instantiate(aPrefab);
        aInstance.transform.position = startPosition;
        Cube.isInstanciedA = 1;
    }

    void UpdateS(){

        sInstance = Instantiate(sPrefab);
        sInstance.transform.position = startPosition;
        Cube.isInstanciedS = 1;
    }

    void UpdateD(){

        dInstance = Instantiate(dPrefab);
        dInstance.transform.position = startPosition;
        Cube.isInstanciedD = 1;
    }
}

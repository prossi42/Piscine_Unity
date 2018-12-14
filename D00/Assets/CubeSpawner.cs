using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

    private         Vector3     startPosition = new Vector3();
    public          GameObject  aPrefab;
    public          GameObject  sPrefab;
    public          GameObject  dPrefab;
    public  static  GameObject  aInstance;
    public  static  GameObject  sInstance;
    public  static  GameObject  dInstance;
    private float repopTime;
    private float countTime;
    public static float downSpeedA;   
    public static float downSpeedS;   
    public static float downSpeedD;   

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
            else if (Cube.isInstanciedA == -1)
            {
                repopTime = Random.Range(0.01f, 3.0f);
                countTime = 0f;
                Cube.isInstanciedA = -2;
            }
            else if (Cube.isInstanciedA == -2)
            {
                countTime += Time.deltaTime;
                if (countTime >= repopTime)
                {
                    Cube.isInstanciedA = 0;
                    countTime = 0f;
                }
            }
        }
        else if (gameObject.name == "spawnS")
        {
            if (Cube.isInstanciedS == 0)
                UpdateS();
            else if (Cube.isInstanciedS == -1)
            {
                repopTime = Random.Range(0.01f, 3.0f);
                countTime = 0f;
                Cube.isInstanciedS = -2;
            }
            else if (Cube.isInstanciedS == -2)
            {
                countTime += Time.deltaTime;
                if (countTime >= repopTime)
                {
                    Cube.isInstanciedS = 0;
                    countTime = 0f;
                }
            }
        }
        else
        {
            if (Cube.isInstanciedD == 0)
                UpdateD();
            else if (Cube.isInstanciedD == -1)
            {
                repopTime = Random.Range(0.01f, 3.0f);
                countTime = 0f;
                Cube.isInstanciedD = -2;
            }
            else if (Cube.isInstanciedD == -2)
            {
                countTime += Time.deltaTime;
                if (countTime >= repopTime)
                {
                    Cube.isInstanciedD = 0;
                    countTime = 0f;
                }
            }
        }
    }

    void UpdateA(){

        aInstance = Instantiate(aPrefab);
        aInstance.transform.position = startPosition;
        downSpeedA = Random.Range(-0.03f, -0.005f);
        Cube.isInstanciedA = 1;
    }

    void UpdateS(){

        sInstance = Instantiate(sPrefab);
        sInstance.transform.position = startPosition;
        downSpeedS = Random.Range(-0.03f, -0.005f);
        Cube.isInstanciedS = 1;
    }

    void UpdateD(){

        dInstance = Instantiate(dPrefab);
        dInstance.transform.position = startPosition;
        downSpeedD = Random.Range(-0.03f, -0.005f);
        Cube.isInstanciedD = 1;
    }
}

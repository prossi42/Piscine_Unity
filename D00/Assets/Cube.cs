using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public static int isInstanciedA;
    public static int isInstanciedS;
    public static int isInstanciedD;
    private Vector3 down = new Vector3(0.0f, -0.01f, 0.0f);
    private float precision;
    private float result;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        UpdateA();
        UpdateS();
        UpdateD();
	}

    void UpdateA(){

        if (CubeSpawner.aInstance && gameObject.name == CubeSpawner.aInstance.name)
        {
            if (isInstanciedA == 1)
            {
                down.y = CubeSpawner.downSpeedA;
                CubeSpawner.aInstance.transform.Translate(down);
                if (CubeSpawner.aInstance.transform.position.y < 4.6f)
                {
                    Destroy(CubeSpawner.aInstance);
                    isInstanciedA = -1;
                }
            }
            if (Input.GetKeyDown("a"))
            {
                precision = CubeSpawner.aInstance.transform.position.y - 5f;
                if (precision < 0)
                    precision *= -1;
                precision = precision / 0.5f;
                if (precision > 1)
                    result = 0;
                else
                {
                    precision *= 100;
                    result = 100 - precision;
                    Destroy(CubeSpawner.aInstance);
                    isInstanciedA = -1;
                }
                Debug.Log("Precision: " + result);
            }
        }
    }

    void UpdateS()
    {
        if (CubeSpawner.sInstance && gameObject.name == CubeSpawner.sInstance.name)
        {
            if (isInstanciedS == 1)
            {
                down.y = CubeSpawner.downSpeedS;
                CubeSpawner.sInstance.transform.Translate(down);
                if (CubeSpawner.sInstance.transform.position.y < 4.6f)
                {
                    Destroy(CubeSpawner.sInstance);
                    isInstanciedS = -1;
                }
            }
            if (Input.GetKeyDown("s"))
            {
                precision = CubeSpawner.sInstance.transform.position.y - 5f;
                if (precision < 0)
                    precision *= -1;
                precision = precision / 0.5f;
                if (precision > 1)
                    result = 0;
                else
                {
                    precision *= 100;
                    result = 100 - precision;
                    Destroy(CubeSpawner.sInstance);
                    isInstanciedS = -1;
                }
                Debug.Log("Precision: " + result);
            }
        }
    }

    void UpdateD()
    {
        if (CubeSpawner.dInstance && gameObject.name == CubeSpawner.dInstance.name)
        {
            if (isInstanciedD == 1)
            {
                down.y = CubeSpawner.downSpeedD;
                CubeSpawner.dInstance.transform.Translate(down);
                if (CubeSpawner.dInstance.transform.position.y < 4.6f)
                {
                    Destroy(CubeSpawner.dInstance);
                    isInstanciedD = -1;
                }
            }
            if (Input.GetKeyDown("d"))
            {
                precision = CubeSpawner.dInstance.transform.position.y - 5f;
                if (precision < 0)
                    precision *= -1;
                precision = precision / 0.5f;
                if (precision > 1)
                    result = 0;
                else
                {
                    precision *= 100;
                    result = 100 - precision;
                    Destroy(CubeSpawner.dInstance);
                    isInstanciedD = -1;
                }
                Debug.Log("Precision: " + result);
            }
        }
    }
}

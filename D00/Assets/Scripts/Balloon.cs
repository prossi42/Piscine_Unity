using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour {

    private float startingTime;
    private float endingTime;
    private int outOfBreath;
    private int breathNumber;
    private int gameOver;
    private int first;
    private float downScaleTime;
    private float outOfBreathTime;
    private Vector3 downScale = new Vector3(0.01f, 0.01f, 0.01f);
    private Vector3 upScale = new Vector3(0.01f, 0.01f, 0.01f);
    private Vector3 startingScale = new Vector3(1f, 1f, 1f);
    public GameObject outOfBreathText;
    public GameObject gameOverText;
    public GameObject goingtoExplodeText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
        if (gameOver == 0)
        {
            if (outOfBreath == 0)
            {
                if (Input.GetKeyDown("space"))
                {
                    if (first == 0)
                    {
                        startingTime = Time.time;
                        downScaleTime = 0.0f;
                        breathNumber = 0;
                        transform.localScale += upScale;
                        first = 1;
                    }
                    else
                    {
                        transform.localScale += upScale;
                        breathNumber++;
                        if (breathNumber == 15)
                        {
                            outOfBreath = 1;
                            outOfBreathTime = 0f;
                            outOfBreathText.SetActive(true);
                        }
                    }
                }
            }
            else
            {
                outOfBreathTime += Time.deltaTime;
                if (outOfBreathTime >= 10f)
                {
                    outOfBreath = 0;
                    breathNumber = 0;
                    outOfBreathText.SetActive(false);
                }
            }
            if (first == 1)
            {
                downScaleTime += Time.deltaTime;
                if (downScaleTime > 1f)
                {
                    breathNumber--;
                    downScaleTime = 0.0f;
                    transform.localScale -= downScale;
                    if (transform.localScale == startingScale)
                    {
                        gameOver = 2;
                    }
                }
                if (transform.localScale.x >= 1.12f)
                    goingtoExplodeText.SetActive(true);
                else
                    goingtoExplodeText.SetActive(false);
                if (transform.localScale.x >= 1.14)
                    gameOver = 1;
            }
        }
        else if (gameOver == 1 || gameOver == 2)
        {
            GameOver();
            gameOver = 3;
        }
	}

    void GameOver()
    {
        Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.time - startingTime) + "s");
        gameOverText.SetActive(true);
        outOfBreathText.SetActive(false);
        goingtoExplodeText.SetActive(false);
        if (gameOver == 1)
            Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour {

    public Text ScoreText;
    public int currentScore;

    public int currentCount;

	// Use this for initialization
	void Start () {
        currentScore = currentCount;
	}
	
	// Update is called once per frame
	void Update () {

        ScoreText.text = "Score: " + currentScore;
            
        
	}
    public void SetCurrentScore()
        {
        currentScore += 1;
        }
}

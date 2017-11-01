using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour {

    public Text ScoreText;
    public int currentScore;

    public int currentCount;

    public int[] toLevelUp;

    public string levelToLoad;

	// Use this for initialization
	void Start () {
        currentScore = currentCount;
	}
	
	// Update is called once per frame
	void Update () {

        if(currentScore >= toLevelUp[currentCount])
        {
            SceneManager.LoadScene(levelToLoad);
        }


        ScoreText.text = "Score: " + currentScore;
            
        
	}
    public void SetCurrentScore()
        {
        currentScore += 1;
        }
}

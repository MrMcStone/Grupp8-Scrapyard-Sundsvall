using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    Text text;
    static int score;

    public int Score
    {
        get { return score; }
        set { score += value; PlayerPrefs.SetInt("Score", score); text.text = "Score: " + score; }
    }

	void Start ()
    {
        text = GameObject.Find("ScoreText").GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score");
        text.text = "Score: " + score;
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            score = 0;
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetInt("LevelsCompleted", 0);
        }

    }
}
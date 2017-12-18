using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    Text text;
    static int score;

    public int Score
    {
        get { return score; }
        set { score += value; PlayerPrefs.SetInt("Score", score); }
    }

	void Start ()
    {
        text = GameObject.Find("ScoreText").GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score");
	}
	
	void Update ()
    {
        text.text = "Score: " + score;
    }
}
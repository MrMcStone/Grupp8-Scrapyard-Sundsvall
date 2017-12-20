using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LockedLevelButtons : MonoBehaviour
{

    [SerializeField] Sprite lockedIcon;
    [SerializeField] Button button;
    [SerializeField] Text text;


    void Start()
    {

        if (PlayerPrefs.GetInt("LevelsCompleted") < 1 && name == "Level2")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 2 && name == "Level3")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 3 && name == "Level4")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 4 && name == "Level5")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 5 && name == "Level6")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 6 && name == "Level7")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 7 && name == "Level8")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 8 && name == "Level9")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 9 && name == "Level10")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 10 && name == "Level11")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 11 && name == "Level12")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 12 && name == "Level13")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 13 && name == "Level14")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
        else if (PlayerPrefs.GetInt("LevelsCompleted") < 14 && name == "Level15")
        {
            button.GetComponent<Image>().sprite = lockedIcon;
            text.text = "";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelectionButtons : MonoBehaviour {

	
    void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    void Level2()
    {
        if(PlayerPrefs.GetInt("LevelsCompleted") > 1)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    void Level3()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 2)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    void Level4()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 3)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    void Level5()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 4)
        {
            SceneManager.LoadScene("Level5");
        }
    }
    void Level6()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 5)
        {
            SceneManager.LoadScene("Level6");
        }
    }
    void Level7()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 6)
        {
            SceneManager.LoadScene("Level7");
        }
    }
    void Level8()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 7)
        {
            SceneManager.LoadScene("Level8");
        }
    }
    void Level9()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 8)
        {
            SceneManager.LoadScene("Level9");
        }
    }
    void Level10()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 9)
        {
            SceneManager.LoadScene("Level10");
        }
    }
    void Level11()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 10)
        {
            SceneManager.LoadScene("Level11");
        }
    }
    void Level12()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 11)
        {
            SceneManager.LoadScene("Level12");
        }
    }
    void Level13()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 12)
        {
            SceneManager.LoadScene("Level13");
        }
    }
    void Level14()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 13)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    void Level15()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") > 14)
        {
            SceneManager.LoadScene("Level15");
        }
    }
}

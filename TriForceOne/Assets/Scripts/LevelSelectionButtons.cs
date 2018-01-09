using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelectionButtons : MonoBehaviour
{


    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 1)
        {
            SceneManager.LoadScene("Level2");
        }
    }
    public void Level3()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 2)
        {
            SceneManager.LoadScene("Level3");
        }
    }
    public void Level4()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 3)
        {
            SceneManager.LoadScene("Level4");
        }
    }
    public void Level5()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 4)
        {
            SceneManager.LoadScene("Level5");
        }
    }
    public void Level6()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 5)
        {
            SceneManager.LoadScene("Level6");
        }
    }
    public void Level7()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 6)
        {
            SceneManager.LoadScene("Level7");
        }
    }
    public void Level8()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 7)
        {
            SceneManager.LoadScene("Level8");
        }
    }
    public void Level9()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 8)
        {
            SceneManager.LoadScene("Level9");
        }
    }
    public void Level10()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 9)
        {
            SceneManager.LoadScene("Level10");
        }
    }
    public void Level11()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 10)
        {
            SceneManager.LoadScene("Level11");
        }
    }
    public void Level12()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 11)
        {
            SceneManager.LoadScene("Level12");
        }
    }
    public void Level13()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 12)
        {
            SceneManager.LoadScene("Level13");
        }
    }
    public void Level14()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 13)
        {
            SceneManager.LoadScene("Level14");
        }
    }
    public void Level15()
    {
        if (PlayerPrefs.GetInt("LevelsCompleted") >= 14)
        {
            SceneManager.LoadScene("Level15");
        }
    }
}

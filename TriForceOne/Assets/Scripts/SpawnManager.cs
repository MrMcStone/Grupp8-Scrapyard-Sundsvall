using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] int thisLevel;


    public SpawnElement[][] waves = new SpawnElement[5][];

    public SpawnElement[][] spawnWaves = new SpawnElement[5][];

    //När det är 50 min innan inläming får man fulkoda. Sådetså
    public GameObject victoryScreen;
	public GameObject levelCompleted;

    public SpawnElement[] wave0;
    public SpawnElement[] wave1;
    public SpawnElement[] wave2;
    public SpawnElement[] wave3;
    public SpawnElement[] wave4;

    public int currentWave = 0;
    public int currentElement = 0;
    public int currentCount = 0;



    bool waiting;
    static int enemyCount;
    static int thisWave;

    SpawnElement curSe;


    Text waveText;

    EnemyManager enemyManager;

    public GameObject spawnPos;

    public Toggle skipToggle;

    public Text countdownText;

    public Text enemiesAlive;


    void Start()
    {

        enemyManager = GetComponent<EnemyManager>();

        waiting = true;

        waveText = GameObject.Find("WaveText").GetComponent<Text>();
        enemyCount = 0;
        thisWave = 0;
        waveText.text = "Level: " + (thisLevel).ToString();
        waves[0] = wave0;
        waves[1] = wave1;
        waves[2] = wave2;
        waves[3] = wave3;
        waves[4] = wave4;
        foreach (SpawnElement element in waves[thisWave])
        {
            enemyCount += element.count;
        }
    }



    void Update()
    {
        if (waiting && Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine("WaitForWave");
            StartCoroutine("SpawnEnemy");
            waiting = false;
            enemiesAlive.text = "Enemies: " + enemyCount.ToString();
        }
    }

	public void SpawnWaveButton(){
		if (waiting) {
			StopCoroutine ("WaitForWave");
			StartCoroutine ("SpawnEnemy");
			waiting = false;
            enemiesAlive.text = "Enemies: " + enemyCount.ToString();

        }
    }
    IEnumerator SpawnEnemy()
    {
        curSe = waves[currentWave][currentElement];
        if (curSe.enemy)
        {
            GameObject g = curSe.enemy as GameObject;
            if (curSe.health > 0)
            {
                g.GetComponent<Enemy>().Health = curSe.health;
            }
            enemyManager.AddEnemy(Instantiate(g, spawnPos.transform.position, Quaternion.identity) as GameObject);
        }
        yield return new WaitForSeconds(curSe.delay);
        NextSpawn();
    }

    void NextSpawn()
    {
        if (currentCount + 1 < waves[currentWave][currentElement].count)
        {
            currentCount++;
        }
        else
        {
            if (currentWave < waves.GetLength(0))
            {
                if (currentElement + 1 < waves[currentWave].GetLength(0))
                {
                    currentElement++;
                    currentCount = 0;
                }
                else
                {
                    currentWave++;
                    currentElement = 0;
                    currentCount = 0;
                    return;
                }
            }
            else
            {
                if (currentElement + 1 < waves[currentWave].GetLength(0))
                {
                    currentElement++;
                    currentCount = 0;
                }
                else
                {
                    return;
                }
            }
        }
		if (currentWave < waves.Length)
			StartCoroutine ("SpawnEnemy"); 
            
    }

	IEnumerator LevelCompleted()
	{
        if(PlayerPrefs.GetInt("LevelsCompleted") < thisLevel)
        {
            PlayerPrefs.SetInt("LevelsCompleted", thisLevel);
        }
		levelCompleted.SetActive (true);
        yield return new WaitForSeconds(1f);
        GetComponent<MenuManagerScript>().paused = true;
        GameObject.Find("FoundationMarker").GetComponent<FoundationMarkerScript>().HideMarker();
        
        Time.timeScale = 0; 
	}

    public void EnemyDead()
    {
        enemyCount--;
        enemiesAlive.text = "Enemies: " + enemyCount.ToString();
        if (enemyCount <= 0)
        {

            GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
            foreach (GameObject tower in towers)
            {
                if (tower.GetComponent<CombatTower>())
                {
                    tower.GetComponent<CombatTower>().AmmoRestock();
                }
            }
			if (currentWave < waves.Length) {

				StartCoroutine(LevelCompleted()); 
				StartCoroutine("WaitForWave");

			}
                
            else
            {
                victoryScreen.SetActive(true);
                Time.timeScale = 0;

            }
        }
    }

    public int GetWave()
    {
        return thisWave;
    }

    IEnumerator WaitForWave()
    {

        thisWave++;
        foreach (SpawnElement element in waves[thisWave])
        {
            enemyCount += element.count;

        }

        waveText.text = "Level: " + thisLevel.ToString();
        GameObject.Find("WaveSound").GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(1f);
        waiting = true;

        if (waiting && Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine("WaitForWave");
            StartCoroutine("SpawnEnemy");
            waiting = false;
        }
    }
}
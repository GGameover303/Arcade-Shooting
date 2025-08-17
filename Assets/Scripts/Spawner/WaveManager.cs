using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> waveEnemy;
    public int currentWave = 0;

    GameManager gameManager;

    bool isSpawned = false;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Start()
    {
        
        StartCoroutine("btwtimeSpawn");
    }

    void Update()
    {
        
        if(gameManager.currentEnemy.Count == 0)
        {
            isSpawned = false;
        }
    }

    void SpawnWave()
    {
        waveEnemy[currentWave].SetActive(enabled);
        isSpawned = true;
        Debug.Log("Spawned Now!!!" + " " + "Current Wave Is" + " " + (currentWave + 1));
        currentWave++;
        

    }

    IEnumerator btwtimeSpawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(8.0f);
            if (isSpawned == false)
            {
                gameManager.numWave++;
                SpawnWave();
                Debug.Log("Spawned");
            } 
        }    
    }
}

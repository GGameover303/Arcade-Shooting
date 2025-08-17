using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> currentEnemy;
    StatusPlayer player;
    WaveManager waveManager;
    public GameObject currentGame;
    public GameObject endGame;
    public GameObject lose;
    public GameObject win;

    public int numWave;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<StatusPlayer>();
        waveManager = GameObject.Find("WaveManager").GetComponent<WaveManager>();
    }

    void Update()
    {
        
        if(player.currentHealth <= 0)
        {
            currentGame.SetActive(false);
            endGame.SetActive(true);
            lose.SetActive(true);
        }
        if(numWave > waveManager.waveEnemy.Count)
        {
            currentGame.SetActive(false);
            endGame.SetActive(true);
            win.SetActive(true);
        }
        
    }
}

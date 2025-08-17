using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyPrefab;
    [SerializeField] List<Transform> changePosition;
    GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        GenerateSpawn();
    }

    void GenerateSpawn()
    {
        
        for (int i = 0; i < enemyPrefab.Count; i++)
        {
            GameObject tmpEnemy = Instantiate(enemyPrefab[i], changePosition[i].transform.position, Quaternion.identity);
            gameManager.currentEnemy.Add(tmpEnemy);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeal : MonoBehaviour
{

    StatusPlayer statusPlayer;
    HealthBar healthBar;

    void Awake()
    {
        statusPlayer = GameObject.Find("Player").GetComponent<StatusPlayer>();
        healthBar = GameObject.Find("HPSystem").GetComponent<HealthBar>();
    }

    void Update()
    {
       transform.Translate(Vector2.down * 2 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            statusPlayer.currentHealth += 50;
            healthBar.SetHealth(statusPlayer.currentHealth);
            Destroy(gameObject);
        }
    }
}

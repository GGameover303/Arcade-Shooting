using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLevelUp : MonoBehaviour
{
    GunLevel gunLevel;

    private void Awake()
    {
        gunLevel = GameObject.Find("Gun").GetComponent<GunLevel>();
    }

    void Update()
    {
        transform.Translate(Vector2.down * 2 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            gunLevel.levelUp(1);
            Destroy(gameObject);
        }
    }
}

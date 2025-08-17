using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] protected string targetBullet;
    [SerializeField] protected float damgeBullet;
    //[SerializeField] protected Animation effectBullet;
    //[SerializeField] protected AudioClip soundBullet;


    void Update()
    {
        Physics2D.IgnoreLayerCollision(6, 6);
        if (transform.position.y >= 12 || transform.position.y <= -12 || transform.position.x >= 18 || transform.position.x <= -18)
        {
            Destroy(gameObject);
        }
        
    }


}

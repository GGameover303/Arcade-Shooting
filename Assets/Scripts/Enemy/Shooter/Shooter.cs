using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shooter : Enemy
{
    CircleCollider2D boxColl;
    float timer;

    [SerializeField] float shootDelay;
    [SerializeField] Transform bulletPos;
    GameObject target;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");

        boxColl = GetComponent<CircleCollider2D>();
        boxColl.enabled = false; //Disable HitBox

        endPosition = new Vector2 (transform.position.x,transform.position.y - endPositionY);
    }

    void Update()
    {
        enemyPos = transform;
        if (reachedPosiotion == true && target != null) 
        {
            boxColl.enabled = true; //Enable HitBox

            timer += Time.deltaTime;

            if (timer >= shootDelay)
            {
                timer = 0;
                Shoot();
            }
        }

    }

    void FixedUpdate()
    {
        if (transform.position.y != endPosition.y && reachedPosiotion == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPosition, speed * Time.deltaTime);
            if (transform.position.y == endPosition.y)
            {
                reachedPosiotion = true;
            }
        }
    } // Enter Scence

    void Shoot()
    {
         GameObject tmpBullet =  Instantiate(bulletPrefab, bulletPos.position, Quaternion.identity);
    }
}

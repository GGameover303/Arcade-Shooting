using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyShooter : Enemy
{
    CircleCollider2D boxColl;
    float timer;

    [SerializeField] float shootDelay;
    [SerializeField] List<Transform> bulletPos;


    void Start()
    {
        boxColl = GetComponent<CircleCollider2D>();
        boxColl.enabled = false; //Disable HitBox

        endPosition = new Vector2(transform.position.x, transform.position.y - endPositionY);
    }

    void Update()
    {
        enemyPos = transform;
        if (reachedPosiotion == true)
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
    }

    void Shoot()
    {
        foreach (Transform gun in bulletPos)
        {
            GameObject tmpBullet = Instantiate(bulletPrefab, gun.transform.position, Quaternion.identity);
        }
    }
}

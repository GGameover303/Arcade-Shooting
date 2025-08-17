using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHeavyShooter : Bullet
{
    [SerializeField] float speedBullet;
    float lifeTime;
    void Start()
    {
        float randomAngle = Random.Range(-45f, 45f);
        transform.rotation = Quaternion.Euler(0f, 0f, randomAngle);
    }

    void Update()
    {
        lifeTime += Time.deltaTime;
        transform.Translate(Vector2.down * speedBullet * Time.deltaTime);
        if(lifeTime >= 3)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == targetBullet)
        {
            Destroy(gameObject);
            var statusComponent = coll.GetComponent<StatusPlayer>();

            if (statusComponent != null)
            {
                statusComponent.TakeDamage(damgeBullet);
            }
        }
    }
}

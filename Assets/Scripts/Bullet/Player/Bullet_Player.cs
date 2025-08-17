using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Player : Bullet
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == targetBullet && coll != null)
        {
            if (coll != null)
            {
                var statusComponent = coll.GetComponent<Enemy>();
                if (statusComponent != null)
                {
                    statusComponent.TakeDamage(damgeBullet);
                }
                Destroy(gameObject);
            }
        }
    }
}

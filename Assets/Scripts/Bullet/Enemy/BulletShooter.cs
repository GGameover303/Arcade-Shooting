using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : Bullet
{
    [SerializeField] float speedBullet;
    GameObject target;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag(targetBullet);
    }
    void Start()
    {
        Vector2 dirPos = target.transform.position - transform.position;
        rb.velocity = new Vector2(dirPos.x, dirPos.y).normalized * speedBullet;

        float rot = Mathf.Atan2(-dirPos.y,-dirPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot - 90);
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

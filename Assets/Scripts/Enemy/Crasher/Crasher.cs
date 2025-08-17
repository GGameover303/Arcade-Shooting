using UnityEngine;

public class Crasher : Enemy
{                    
    float lifeTime;

    CircleCollider2D coll;
    GameObject target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");

        coll = GetComponent<CircleCollider2D>();
        coll.enabled = false;

        endPosition = new Vector2(transform.position.x, transform.position.y - endPositionY);
    }

    void Update()
    {
        enemyPos = transform;
        if (reachedPosiotion == true && target != null)
        {
            coll.enabled = true;

            LookPlayer();

            lifeTime += Time.deltaTime;



            if (lifeTime <= 5)
             {
                 transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
             }
             else { boomSelf(); }
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

    void LookPlayer()
    {
        Vector2 dirPos = target.transform.position - transform.position;
        float rot = Mathf.Atan2(-dirPos.y, -dirPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot - 90);
    }

    void boomSelf()
    {
        GameObject tmpbomb = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        gameManager.currentEnemy.Remove(gameObject);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBomb : MonoBehaviour
{
    [SerializeField] float damgeBomb;

    void Start()
    {
        StartCoroutine(waiting());
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Destroy(gameObject);
            var statusComponent = coll.GetComponent<StatusPlayer>();

            if (statusComponent != null)
            {
                statusComponent.TakeDamage(damgeBomb);
            }
        }
    }
}

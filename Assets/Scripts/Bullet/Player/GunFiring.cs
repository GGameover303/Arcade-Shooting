using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GunFiring : MonoBehaviour
{
    [SerializeField] Transform gunPoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float cooldownShoot;
    [SerializeField] float speedBullet;
    float countTime;
    Vector2 startPoint;

    void Update()
    {

        startPoint = gunPoint.position;
        countTime += Time.deltaTime;

        if(countTime >= cooldownShoot)
        {
            
            
            Fire();

            countTime = 0;
        }
    }

    void Fire()
    {

        GameObject bulletShoot = Instantiate(bulletPrefab,gunPoint.position, Quaternion.identity);
        Rigidbody2D bulletRb = bulletShoot.GetComponent<Rigidbody2D>();

        bulletRb.velocity = gunPoint.up * speedBullet;


    }
}

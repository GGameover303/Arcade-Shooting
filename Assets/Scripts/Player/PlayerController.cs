using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField]  Rigidbody2D rb;
    [SerializeField]  float speed;
    Vector2 moveMent;

    void Start()
    {
        
    }

    
    void Update()
    {
        moveMent.x = Input.GetAxisRaw("Horizontal");
        moveMent.y = Input.GetAxisRaw("Vertical");

        #region LockMoveMent
        if (transform.position.y <= -9.2)
        {
            transform.position = new Vector2(transform.position.x, -9.2f);
        }
        else if(transform.position.y >= 9.2)
        {
            transform.position = new Vector2(transform.position.x, 9.2f);
        }
        if (transform.position.x >= 16.7)
        {
            transform.position = new Vector2(16.7f, transform.position.y);
        }
        else if (transform.position.x <= -16.7)
        {
            transform.position = new Vector2(-16.7f, transform.position.y);
        }
        #endregion 
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveMent.x * speed, moveMent.y * speed);
    }



    
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region Movement
    [SerializeField] protected float speed;                     
    [SerializeField] protected int endPositionY;
                     protected Vector2 endPosition = new Vector2(0, 0);
                     protected bool reachedPosiotion = false;
    #endregion

    #region Attacking
    [SerializeField] protected GameObject bulletPrefab;
    
    #endregion

    #region HPEnemy
    [SerializeField] protected float maxHealthEnemy;
    [SerializeField] protected float currentHealthEnemy;
    #endregion

    protected GameManager gameManager;
              Item _item;
    protected Transform enemyPos;
    

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _item = GameObject.Find("ItemsManager").GetComponent<Item>();
        currentHealthEnemy = maxHealthEnemy;
    }

    public void TakeDamage(float amoutDamage)
    {
        currentHealthEnemy -= amoutDamage;
        if (currentHealthEnemy <= 0)
        {
            _item.itemDrop(enemyPos);
            gameManager.currentEnemy.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}

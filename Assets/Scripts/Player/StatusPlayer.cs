using UnityEngine;

public class StatusPlayer : MonoBehaviour
{
    [SerializeField] float maxHealth;
    [SerializeField] public float currentHealth;
    
    [SerializeField] HealthBar healthBar;


    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth > maxHealth)
        {
            
            currentHealth = maxHealth;
        }
    }

    public void TakeDamage(float amoutDamage)
    {
        currentHealth -= amoutDamage;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
        healthBar.SetHealth(currentHealth);
    }
}

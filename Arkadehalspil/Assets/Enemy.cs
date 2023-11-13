using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthbar;

    public GameObject winscreen;
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    public void Takedamage(int damageamount)
    {
        currentHealth -= damageamount;  


        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        winscreen.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Takedamage(5);

            healthbar.SetHealth(currentHealth);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Takedamage(20);

            healthbar.SetHealth(currentHealth);
        }
    }
}

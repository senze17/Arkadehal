using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamestate : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    public Slider EnemyHealth;
    public Slider PlayerHealth;
    public Button BtnAttack; 

    private bool IsPlayerTurn = true;

    public void Attack(GameObject target, float damage)
    {
        if (target == Enemy)
        {
            EnemyHealth.value -= damage;
        }
        else
        {
            PlayerHealth.value -= damage;
        }

        ChangeTurn();
    }

    public void btnAttack()
    {
        Attack(Enemy, 10);
    }

    private void ChangeTurn()
    {
        IsPlayerTurn = !IsPlayerTurn;
    }
}

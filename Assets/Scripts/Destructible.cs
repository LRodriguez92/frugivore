using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public int maximumHitPoints = 1;

    private int currentHitPoints;

    public int GetCurrentHitPoints()
    {
        return currentHitPoints;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHitPoints = maximumHitPoints;
    }

    public void TakeDamage(int damageAmount)
    {
        ModifyHitPoints(-damageAmount);
    }

    public void HealDamage(int healAmount)
    {
        ModifyHitPoints(healAmount);
    }

    private void ModifyHitPoints(int modAmount)
    {
        currentHitPoints += modAmount;

        if (currentHitPoints > maximumHitPoints)
        {
            currentHitPoints = maximumHitPoints;
        }

        if (currentHitPoints <= 0)
        {
            Die();
        }

        Debug.Log(currentHitPoints);
    }

    private void Die()
    {
        //Could add animation here!
        Destroy(gameObject);
    }
}
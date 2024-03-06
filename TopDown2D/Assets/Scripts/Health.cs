using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
    [SerializeField] public float maxHealth = 10;
    

    //[SerializeField] private GameObject bloodParticle;
    public float currentHealth;

    //[SerializeField] private Renderer renderer;
    //[SerializeField] private float flashTime = 0.2f;

    private void Start()
    {
        //currentHealth.Value = 1;
        currentHealth = maxHealth;
    }

    #region Part from complex video
    /*public void Reduce(int damage)
    {
        //currentHealth.Value -= damage / maxHealth;
        CreateHitFeedback();
       // if (currentHealth.Value <= 0)
        {
            Die();
        }
    }

    public void AddHealth(int healthBoost)
    {
        //int health = Mathf.RoundToInt(currentHealth.Value * maxHealth);
        //int val = health + healthBoost;
        //currentHealth.Value = (val > maxHealth ? maxHealth : val / maxHealth);
    }

    private void CreateHitFeedback()
    {
        //Instantiate(bloodParticle, transform.position, Quaternion.identity);
        StartCoroutine(FlashFeedback());
    }

    private IEnumerator FlashFeedback()
    {
        renderer.material.SetInt("_Flash", 1);
        yield return new WaitForSeconds(flashTime);
        renderer.material.SetInt("_Flash", 0);
    }

    private void Die()
    {
        Debug.Log("Died");
        //currentHealth.Value = 1;
    }*/
    #endregion

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            //dead
        }
    }

    public void Increasehealth(int amount)
    {
        currentHealth += amount;
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}


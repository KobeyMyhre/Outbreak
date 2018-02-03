using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable {

    public float maxHealth;
    public float currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void takeDamage(float damageTaken)
    {
        currentHealth -= damageTaken;
        die();
    }

    public void die()
    {
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}

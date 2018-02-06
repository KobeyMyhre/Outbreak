using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Crawler : MonoBehaviour, IDamageable {

    NavMeshAgent agent;
    public GameObject player;
    public GameObject hitBox;
    public float attackDelay;
    private float attackTimer;
    public float maxHealth;
    float currentHealth;
    Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
        attackTimer = 0;
        agent = GetComponent<NavMeshAgent>();
	}
	
    void offCollider()
    {
        hitBox.SetActive(false);
    }

	// Update is called once per frame
	void Update ()
    {
        agent.destination = player.transform.position;
        if(Vector3.Distance(transform.position, player.transform.position) < 2)
        {
            if(attackTimer <= 0)
            {
                hitBox.SetActive(true);
                Invoke("offCollider", .3f);
                attackTimer = attackDelay;
            }
           
        }
        attackTimer -= Time.deltaTime;
	}

    void TurnWhite()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
        GetComponent<Renderer>().material.color = Color.red;
        Invoke("TurnWhite", .2f);
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

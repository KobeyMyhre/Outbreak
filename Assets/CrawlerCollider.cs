using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerCollider : MonoBehaviour {

    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        IDamageable attempt = other.GetComponent<IDamageable>();
        if(attempt != null)
        {
            attempt.takeDamage(damage);
            gameObject.SetActive(false);
        }
    }
}

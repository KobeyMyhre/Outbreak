using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnockBackCollider : MonoBehaviour {

    public float knockForce;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {

            
           
            
        }
    }

    
}
